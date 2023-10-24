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

namespace playground
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the playgroundRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("ad0f3130-4cce-4bde-bc8e-05bc0c06e04f")]
    public partial class playgroundRepository : RepoGenBaseFolder
    {
        static playgroundRepository instance = new playgroundRepository();
        playgroundRepositoryFolders.Form1AppFolder _form1;
        RepoItemInfo _hello_worldInfo;

        /// <summary>
        /// Gets the singleton class instance representing the playgroundRepository element repository.
        /// </summary>
        [RepositoryFolder("ad0f3130-4cce-4bde-bc8e-05bc0c06e04f")]
        public static playgroundRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public playgroundRepository() 
            : base("playgroundRepository", "/", null, 0, false, "ad0f3130-4cce-4bde-bc8e-05bc0c06e04f", ".\\RepositoryImages\\playgroundRepositoryad0f3130.rximgres")
        {
            _form1 = new playgroundRepositoryFolders.Form1AppFolder(this);
            _hello_worldInfo = new RepoItemInfo(this, "hello_world", "/form[@controlname='Form1']/picture[@controlname='pictureBox1']", 10000, null, "de6dc268-9584-4a0e-b490-77a074564d8f");
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ad0f3130-4cce-4bde-bc8e-05bc0c06e04f")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The hello_world item.
        /// </summary>
        [RepositoryItem("de6dc268-9584-4a0e-b490-77a074564d8f")]
        public virtual Ranorex.Picture hello_world
        {
            get
            {
                 return _hello_worldInfo.CreateAdapter<Ranorex.Picture>(true);
            }
        }

        /// <summary>
        /// The hello_world item info.
        /// </summary>
        [RepositoryItemInfo("de6dc268-9584-4a0e-b490-77a074564d8f")]
        public virtual RepoItemInfo hello_worldInfo
        {
            get
            {
                return _hello_worldInfo;
            }
        }

        /// <summary>
        /// The Form1 folder.
        /// </summary>
        [RepositoryFolder("982e7b71-84cd-4756-a9e0-34e7cf491deb")]
        public virtual playgroundRepositoryFolders.Form1AppFolder Form1
        {
            get { return _form1; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class playgroundRepositoryFolders
    {
        /// <summary>
        /// The Form1AppFolder folder.
        /// </summary>
        [RepositoryFolder("982e7b71-84cd-4756-a9e0-34e7cf491deb")]
        public partial class Form1AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _timestampsInfo;
            RepoItemInfo _picture_from_textboxInfo;
            RepoItemInfo _table_dataInfo;

            /// <summary>
            /// Creates a new Form1  folder.
            /// </summary>
            public Form1AppFolder(RepoGenBaseFolder parentFolder) :
                    base("Form1", "/form[@controlname='Form1']", parentFolder, 10000, null, true, "982e7b71-84cd-4756-a9e0-34e7cf491deb", "")
            {
                _timestampsInfo = new RepoItemInfo(this, "timestamps", "picture[@controlname='pictureBox2']", "", 10000, null, "bc14a7cb-fd25-4f46-8dbe-8b67a2ef36cb");
                _picture_from_textboxInfo = new RepoItemInfo(this, "picture_from_textbox", "?/?/text[@accessiblerole='Text']", "", 10000, null, "f9d22526-1347-4fb2-81a7-0ce83b6ee961");
                _table_dataInfo = new RepoItemInfo(this, "table_data", "table[@controlname='mydg']", "", 10000, null, "b583f854-fe23-43ea-8565-d157b68314cc");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("982e7b71-84cd-4756-a9e0-34e7cf491deb")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("982e7b71-84cd-4756-a9e0-34e7cf491deb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The timestamps item.
            /// </summary>
            [RepositoryItem("bc14a7cb-fd25-4f46-8dbe-8b67a2ef36cb")]
            public virtual Ranorex.Picture timestamps
            {
                get
                {
                    return _timestampsInfo.CreateAdapter<Ranorex.Picture>(true);
                }
            }

            /// <summary>
            /// The timestamps item info.
            /// </summary>
            [RepositoryItemInfo("bc14a7cb-fd25-4f46-8dbe-8b67a2ef36cb")]
            public virtual RepoItemInfo timestampsInfo
            {
                get
                {
                    return _timestampsInfo;
                }
            }

            /// <summary>
            /// The picture_from_textbox item.
            /// </summary>
            [RepositoryItem("f9d22526-1347-4fb2-81a7-0ce83b6ee961")]
            public virtual Ranorex.Text picture_from_textbox
            {
                get
                {
                    return _picture_from_textboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The picture_from_textbox item info.
            /// </summary>
            [RepositoryItemInfo("f9d22526-1347-4fb2-81a7-0ce83b6ee961")]
            public virtual RepoItemInfo picture_from_textboxInfo
            {
                get
                {
                    return _picture_from_textboxInfo;
                }
            }

            /// <summary>
            /// The table_data item.
            /// </summary>
            [RepositoryItem("b583f854-fe23-43ea-8565-d157b68314cc")]
            public virtual Ranorex.Table table_data
            {
                get
                {
                    return _table_dataInfo.CreateAdapter<Ranorex.Table>(true);
                }
            }

            /// <summary>
            /// The table_data item info.
            /// </summary>
            [RepositoryItemInfo("b583f854-fe23-43ea-8565-d157b68314cc")]
            public virtual RepoItemInfo table_dataInfo
            {
                get
                {
                    return _table_dataInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
