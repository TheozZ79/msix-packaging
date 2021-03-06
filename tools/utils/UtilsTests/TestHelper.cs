﻿//----------------------------------------------------------------------------------------------------------------------
// <copyright file="TestHelper.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//----------------------------------------------------------------------------------------------------------------------

namespace UtilsTests
{
    using System;
    using System.IO;
    using WEX.Logging.Interop;

    internal class TestHelper : TestBase
    {
        /// <summary>
        /// Helper method to delete a file in the given path.
        /// </summary>
        /// <param name="filePath">Path of the file to be deleted.</param>
        public static void DeleteFileIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    Log.Comment("{0} Tool deleted in the file directory", filePath);
                }
                catch (Exception exception)
                {
                    Log.Comment("Exception caught while deleting file from test directory."
                        + " File Path: " + filePath + " Exception:"
                        + exception.ToString());
                }
            }
        }
    }
}
