﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace repositories_
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Repo1 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("a82540fc-2d46-4007-89c1-cb06c4c3f9c5")]
    public partial class Repo1 : RepoGenBaseFolder
    {
        static Repo1 instance = new Repo1();

        /// <summary>
        /// Gets the singleton class instance representing the Repo1 element repository.
        /// </summary>
        [RepositoryFolder("a82540fc-2d46-4007-89c1-cb06c4c3f9c5")]
        public static Repo1 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Repo1() 
            : base("Repo1", "/", null, 0, false, "a82540fc-2d46-4007-89c1-cb06c4c3f9c5", ".\\RepositoryImages\\Repo1a82540fc.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a82540fc-2d46-4007-89c1-cb06c4c3f9c5")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Repo1Folders
    {
    }
#pragma warning restore 0436
}