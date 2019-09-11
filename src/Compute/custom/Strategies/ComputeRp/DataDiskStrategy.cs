﻿using Microsoft.Azure.Commands.Common.Strategies;
using Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20190301;
using Microsoft.Azure.PowerShell.Cmdlets.Compute.Support;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Commands.Compute.Strategies.ComputeRp
{
    static class DataDiskStrategy
    {
        static IList<T> CreateDataDisks<T>(
            IEnumerable<int> imageDataDiskLuns,
            IEnumerable<int> dataDiskSizes,
            Func<string, int, int?, T> createDataDisk)
        {
            if (dataDiskSizes == null)
            {
                return null;
            }
            imageDataDiskLuns = imageDataDiskLuns.EmptyIfNull();
            var firstLun = imageDataDiskLuns
                .Select(v => v + 1)
                .Concat(new[] { 0 })
                .Max();
            return imageDataDiskLuns
                .Select(lun => createDataDisk(DiskCreateOptionTypes.FromImage, lun, null))
                .Concat(dataDiskSizes.Select((size, i) => createDataDisk(
                    DiskCreateOptionTypes.Empty,
                    i + firstLun,
                    size)))
                .ToList();
        }

        public static IList<IDataDisk> CreateDataDisks(
            IEnumerable<int> imageDataDiskLuns,
            IEnumerable<int> dataDiskSizes)
            => CreateDataDisks(
                imageDataDiskLuns,
                dataDiskSizes,
                (createOption, lun, size) => new DataDisk
                {
                    CreateOption = createOption,
                    Lun = lun,
                    SizeInGb = size,
                } as IDataDisk);

        public static IList<VirtualMachineScaleSetDataDisk> CreateVmssDataDisks(
            IEnumerable<int> dataDisks,
            IEnumerable<int> dataDiskSizes)
            => CreateDataDisks(
                dataDisks,
                dataDiskSizes,
                (createOption, lun, size) => new VirtualMachineScaleSetDataDisk
                {
                    CreateOption = createOption,
                    Lun = lun,
                    SizeInGb = size,
                });
    }
}
