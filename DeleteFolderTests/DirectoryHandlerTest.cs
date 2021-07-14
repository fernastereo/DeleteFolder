using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DeleteFolder;
using System.IO;

namespace DeleteFolderTests
{
    public class DirectoryHandlerTest
    {
        private const string testDir = @"C:\testdirectory";

        [Fact]
        public void DeleteDirectoryRecursively_WhenCalledWithExistingFolder_DeleteTheProvidedDirectory()
        {
            Directory.CreateDirectory(testDir);

            var handler = new DirectoryHandler();

            handler.DeleteDirectoryRecursively(new DirectoryInfo(testDir));

            Assert.False(Directory.Exists(testDir));
        }

        [Fact]
        public void DeleteDirectoryRecursively_WhenCalledWithNoExistingFolder_ThrowDirectoryNotFoundException()
        {
            var handler = new DirectoryHandler();

            Assert.Throws<DirectoryNotFoundException>(
                () => handler.DeleteDirectoryRecursively(new DirectoryInfo(testDir)));
        }

        [Fact]
        public void DeleteDirectory_WhenCalledWithExistingFolder_DeleteTheProvidedDirectory()
        {
            Directory.CreateDirectory(testDir);

            var handler = new DirectoryHandler();

            handler.DeleteDirectory(new DirectoryInfo(testDir));

            Assert.False(Directory.Exists(testDir));
        }

        [Fact]
        public void DeleteDirectory_WhenCalledWithNoExistingFolder_ThrowDirectoryNotFoundException()
        {
            var handler = new DirectoryHandler();

            Assert.Throws<DirectoryNotFoundException>(
                () => handler.DeleteDirectory(new DirectoryInfo(testDir)));
        }

    }
}
