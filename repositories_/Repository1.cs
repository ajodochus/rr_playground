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
    /// The class representing the Repository1 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("25325b62-2bdd-495d-91ac-a1b404be13b9")]
    public partial class Repository1 : RepoGenBaseFolder
    {
        static Repository1 instance = new Repository1();

        /// <summary>
        /// Gets the singleton class instance representing the Repository1 element repository.
        /// </summary>
        [RepositoryFolder("25325b62-2bdd-495d-91ac-a1b404be13b9")]
        public static Repository1 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Repository1() 
            : base("Repository1", "/", null, 0, false, "25325b62-2bdd-495d-91ac-a1b404be13b9", ".\\RepositoryImages\\Repository125325b62.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("25325b62-2bdd-495d-91ac-a1b404be13b9")]
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
    public partial class Repository1Folders
    {
    }
#pragma warning restore 0436
}
