﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            int index = 0;

            app.Groups.Delete(index);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(index);

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
