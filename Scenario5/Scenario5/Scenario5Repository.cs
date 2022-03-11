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

namespace Scenario5
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Scenario5Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("0c7020b3-d7d3-4db5-a597-61de7680019b")]
    public partial class Scenario5Repository : RepoGenBaseFolder
    {
        static Scenario5Repository instance = new Scenario5Repository();
        Scenario5RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the Scenario5Repository element repository.
        /// </summary>
        [RepositoryFolder("0c7020b3-d7d3-4db5-a597-61de7680019b")]
        public static Scenario5Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Scenario5Repository() 
            : base("Scenario5Repository", "/", null, 0, false, "0c7020b3-d7d3-4db5-a597-61de7680019b", ".\\RepositoryImages\\Scenario5Repository0c7020b3.rximgres")
        {
            _applicationundertest = new Scenario5RepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("0c7020b3-d7d3-4db5-a597-61de7680019b")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("95c02c38-c2ee-453a-a606-f4ea22254d53")]
        public virtual Scenario5RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Scenario5RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("95c02c38-c2ee-453a-a606-f4ea22254d53")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _textInfo;
            RepoItemInfo _searchiconInfo;
            RepoItemInfo _fvrtbtnInfo;
            RepoItemInfo _girişyapInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.trendyol.com']", parentFolder, 30000, null, false, "95c02c38-c2ee-453a-a606-f4ea22254d53", "")
            {
                _textInfo = new RepoItemInfo(this, "Text", ".//div[#'auto-complete-app']//input[@type='text']", ".//div[#'auto-complete-app']//input[@type='text']", 30000, null, "31432395-9979-4f62-92b0-7e7b298cac56");
                _searchiconInfo = new RepoItemInfo(this, "SearchIcon", ".//div[#'auto-complete-app']//i", ".//div[#'auto-complete-app']//i", 30000, null, "80bf4053-638d-4ead-ad93-38260f7e3fc0");
                _fvrtbtnInfo = new RepoItemInfo(this, "FvrtBtn", ".//div[#'search-app']/div/div[1]/div[2]/div[3]//i", ".//div[#'search-app']//i", 30000, null, "11427c75-f48c-4a7d-81a6-d537dde71aed");
                _girişyapInfo = new RepoItemInfo(this, "GirişYap", ".//div[#'login-register']//form[@action='https://www.trendyol.com/giris?cb=https%3A%2F%2Fwww.trendyol.com%2Fsr%3Fq%3Dfy9504%26qt%3Dfy9504%26st%3Dfy9504%26os%3D1']/?/?/span[@innertext='Giriş Yap']", ".//div[#'login-register']//form/button/span[@innertext='Giriş Yap']", 30000, null, "c8ba8c70-1136-4bc4-810e-4bf1ba56cbef");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("95c02c38-c2ee-453a-a606-f4ea22254d53")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("95c02c38-c2ee-453a-a606-f4ea22254d53")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("31432395-9979-4f62-92b0-7e7b298cac56")]
            public virtual Ranorex.InputTag Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("31432395-9979-4f62-92b0-7e7b298cac56")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The SearchIcon item.
            /// </summary>
            [RepositoryItem("80bf4053-638d-4ead-ad93-38260f7e3fc0")]
            public virtual Ranorex.ITag SearchIcon
            {
                get
                {
                    return _searchiconInfo.CreateAdapter<Ranorex.ITag>(true);
                }
            }

            /// <summary>
            /// The SearchIcon item info.
            /// </summary>
            [RepositoryItemInfo("80bf4053-638d-4ead-ad93-38260f7e3fc0")]
            public virtual RepoItemInfo SearchIconInfo
            {
                get
                {
                    return _searchiconInfo;
                }
            }

            /// <summary>
            /// The FvrtBtn item.
            /// </summary>
            [RepositoryItem("11427c75-f48c-4a7d-81a6-d537dde71aed")]
            public virtual Ranorex.ITag FvrtBtn
            {
                get
                {
                    return _fvrtbtnInfo.CreateAdapter<Ranorex.ITag>(true);
                }
            }

            /// <summary>
            /// The FvrtBtn item info.
            /// </summary>
            [RepositoryItemInfo("11427c75-f48c-4a7d-81a6-d537dde71aed")]
            public virtual RepoItemInfo FvrtBtnInfo
            {
                get
                {
                    return _fvrtbtnInfo;
                }
            }

            /// <summary>
            /// The GirişYap item.
            /// </summary>
            [RepositoryItem("c8ba8c70-1136-4bc4-810e-4bf1ba56cbef")]
            public virtual Ranorex.SpanTag GirişYap
            {
                get
                {
                    return _girişyapInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The GirişYap item info.
            /// </summary>
            [RepositoryItemInfo("c8ba8c70-1136-4bc4-810e-4bf1ba56cbef")]
            public virtual RepoItemInfo GirişYapInfo
            {
                get
                {
                    return _girişyapInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}