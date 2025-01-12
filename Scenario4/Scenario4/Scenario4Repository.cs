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

namespace Scenario4
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Scenario4Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("1a8d1864-c940-4ef7-96e3-61fbb016364d")]
    public partial class Scenario4Repository : RepoGenBaseFolder
    {
        static Scenario4Repository instance = new Scenario4Repository();
        Scenario4RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        Scenario4RepositoryFolders.ExplorerAppFolder _explorer;

        /// <summary>
        /// Gets the singleton class instance representing the Scenario4Repository element repository.
        /// </summary>
        [RepositoryFolder("1a8d1864-c940-4ef7-96e3-61fbb016364d")]
        public static Scenario4Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Scenario4Repository() 
            : base("Scenario4Repository", "/", null, 0, false, "1a8d1864-c940-4ef7-96e3-61fbb016364d", ".\\RepositoryImages\\Scenario4Repository1a8d1864.rximgres")
        {
            _applicationundertest = new Scenario4RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _explorer = new Scenario4RepositoryFolders.ExplorerAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1a8d1864-c940-4ef7-96e3-61fbb016364d")]
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
        [RepositoryFolder("e7921036-d29a-4662-8563-076599c3a4fc")]
        public virtual Scenario4RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("a4ab9dc3-b207-4d6a-8f6c-b6d22cba9792")]
        public virtual Scenario4RepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Scenario4RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("e7921036-d29a-4662-8563-076599c3a4fc")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            Scenario4RepositoryFolders.ProductDetailAppFolder _productdetailapp;
            RepoItemInfo _httpscdndsmcdncommnresize200200Info;
            RepoItemInfo _httpswwwtrendyolcomsepetInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _searchiconInfo;
            RepoItemInfo _sepeteekleInfo;
            RepoItemInfo _sepeteeklendiInfo;
            RepoItemInfo _divtag1Info;
            RepoItemInfo _divtag2Info;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.trendyol.com']", parentFolder, 30000, null, false, "e7921036-d29a-4662-8563-076599c3a4fc", "")
            {
                _productdetailapp = new Scenario4RepositoryFolders.ProductDetailAppFolder(this);
                _httpscdndsmcdncommnresize200200Info = new RepoItemInfo(this, "HttpsCdnDsmcdnComMnresize200200", ".//div[#'browsing-gw-homepage']/div/div[1]/div/div[2]/a[8]/img[@src='https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15531619355211_Nike.png']", ".//div[#'browsing-gw-homepage']//img[@src='https://cdn.dsmcdn.com/mnresize/200/200/marketing/datascience/Automation/BrandBoutique/2021/4/25/20210425_15531619355211_Nike.png']", 30000, null, "c5a317c1-15d0-4f26-8587-234696c5cc36");
                _httpswwwtrendyolcomsepetInfo = new RepoItemInfo(this, "HttpsWwwTrendyolComSepet", ".//div[#'account-navigation-container']/div/div[2]/a[@href>'https://www.trendyol.com/']", ".//div[#'account-navigation-container']/div/div[2]/a[@href>'https://www.trendyol.com/']", 30000, null, "7b38d957-0d87-4deb-ab69-266321e24f53");
                _textInfo = new RepoItemInfo(this, "Text", ".//div[#'auto-complete-app']//input[@type='text']", ".//div[#'auto-complete-app']//input[@type='text']", 30000, null, "d7e223c5-62a9-4e93-8e9a-b1bce851fe78");
                _searchiconInfo = new RepoItemInfo(this, "SearchIcon", ".//div[#'auto-complete-app']//i", ".//div[#'auto-complete-app']//i", 30000, null, "b0abe3d8-49fa-42af-8855-877ff622fb37");
                _sepeteekleInfo = new RepoItemInfo(this, "SepeteEkle", ".//div[#'search-app']/div/div[1]/div[2]/div[3]/div/div[1]/div[1]/div[2]/button/div[@innertext='Sepete Ekle']", ".//div[#'search-app']//div[@innertext='Sepete Ekle']", 30000, null, "b6a9c9e4-55ae-4c1e-b372-e3da5813d6f0");
                _sepeteeklendiInfo = new RepoItemInfo(this, "SepeteEklendi", ".//div[#'search-app']/div/div[1]/div[2]/div[3]/div/div[1]/div[1]/div[2]/button/div[@innertext='Sepete Eklendi']", ".//div[#'search-app']//div[@innertext='Sepete Eklendi']", 30000, null, "c5854eda-bf19-4a61-a801-0f168d69819a");
                _divtag1Info = new RepoItemInfo(this, "DivTag1", ".//div[#'account-navigation-container']/div/div[2]/a[@href>'https://www.trendyol.com/']/div[@innertext='1']", ".//div[#'account-navigation-container']//div[@innertext='1']", 30000, null, "9a1c876f-707d-4e3f-9ec1-48f30f3ce3f7");
                _divtag2Info = new RepoItemInfo(this, "DivTag2", ".//div[#'account-navigation-container']/div/div[2]/a[@href>'https://www.trendyol.com/']/div[@innertext='2']", ".//div[#'account-navigation-container']//div[@innertext='2']", 30000, null, "a403b9f6-6ec3-4f37-8912-cb160cbd3300");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e7921036-d29a-4662-8563-076599c3a4fc")]
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
            [RepositoryItemInfo("e7921036-d29a-4662-8563-076599c3a4fc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HttpsCdnDsmcdnComMnresize200200 item.
            /// </summary>
            [RepositoryItem("c5a317c1-15d0-4f26-8587-234696c5cc36")]
            public virtual Ranorex.ImgTag HttpsCdnDsmcdnComMnresize200200
            {
                get
                {
                    return _httpscdndsmcdncommnresize200200Info.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The HttpsCdnDsmcdnComMnresize200200 item info.
            /// </summary>
            [RepositoryItemInfo("c5a317c1-15d0-4f26-8587-234696c5cc36")]
            public virtual RepoItemInfo HttpsCdnDsmcdnComMnresize200200Info
            {
                get
                {
                    return _httpscdndsmcdncommnresize200200Info;
                }
            }

            /// <summary>
            /// The HttpsWwwTrendyolComSepet item.
            /// </summary>
            [RepositoryItem("7b38d957-0d87-4deb-ab69-266321e24f53")]
            public virtual Ranorex.ATag HttpsWwwTrendyolComSepet
            {
                get
                {
                    return _httpswwwtrendyolcomsepetInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The HttpsWwwTrendyolComSepet item info.
            /// </summary>
            [RepositoryItemInfo("7b38d957-0d87-4deb-ab69-266321e24f53")]
            public virtual RepoItemInfo HttpsWwwTrendyolComSepetInfo
            {
                get
                {
                    return _httpswwwtrendyolcomsepetInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("d7e223c5-62a9-4e93-8e9a-b1bce851fe78")]
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
            [RepositoryItemInfo("d7e223c5-62a9-4e93-8e9a-b1bce851fe78")]
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
            [RepositoryItem("b0abe3d8-49fa-42af-8855-877ff622fb37")]
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
            [RepositoryItemInfo("b0abe3d8-49fa-42af-8855-877ff622fb37")]
            public virtual RepoItemInfo SearchIconInfo
            {
                get
                {
                    return _searchiconInfo;
                }
            }

            /// <summary>
            /// The SepeteEkle item.
            /// </summary>
            [RepositoryItem("b6a9c9e4-55ae-4c1e-b372-e3da5813d6f0")]
            public virtual Ranorex.DivTag SepeteEkle
            {
                get
                {
                    return _sepeteekleInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The SepeteEkle item info.
            /// </summary>
            [RepositoryItemInfo("b6a9c9e4-55ae-4c1e-b372-e3da5813d6f0")]
            public virtual RepoItemInfo SepeteEkleInfo
            {
                get
                {
                    return _sepeteekleInfo;
                }
            }

            /// <summary>
            /// The SepeteEklendi item.
            /// </summary>
            [RepositoryItem("c5854eda-bf19-4a61-a801-0f168d69819a")]
            public virtual Ranorex.DivTag SepeteEklendi
            {
                get
                {
                    return _sepeteeklendiInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The SepeteEklendi item info.
            /// </summary>
            [RepositoryItemInfo("c5854eda-bf19-4a61-a801-0f168d69819a")]
            public virtual RepoItemInfo SepeteEklendiInfo
            {
                get
                {
                    return _sepeteeklendiInfo;
                }
            }

            /// <summary>
            /// The DivTag1 item.
            /// </summary>
            [RepositoryItem("9a1c876f-707d-4e3f-9ec1-48f30f3ce3f7")]
            public virtual Ranorex.DivTag DivTag1
            {
                get
                {
                    return _divtag1Info.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTag1 item info.
            /// </summary>
            [RepositoryItemInfo("9a1c876f-707d-4e3f-9ec1-48f30f3ce3f7")]
            public virtual RepoItemInfo DivTag1Info
            {
                get
                {
                    return _divtag1Info;
                }
            }

            /// <summary>
            /// The DivTag2 item.
            /// </summary>
            [RepositoryItem("a403b9f6-6ec3-4f37-8912-cb160cbd3300")]
            public virtual Ranorex.DivTag DivTag2
            {
                get
                {
                    return _divtag2Info.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTag2 item info.
            /// </summary>
            [RepositoryItemInfo("a403b9f6-6ec3-4f37-8912-cb160cbd3300")]
            public virtual RepoItemInfo DivTag2Info
            {
                get
                {
                    return _divtag2Info;
                }
            }

            /// <summary>
            /// The ProductDetailApp folder.
            /// </summary>
            [RepositoryFolder("48b93769-1947-482b-8343-e612d58a9655")]
            public virtual Scenario4RepositoryFolders.ProductDetailAppFolder ProductDetailApp
            {
                get { return _productdetailapp; }
            }
        }

        /// <summary>
        /// The ProductDetailAppFolder folder.
        /// </summary>
        [RepositoryFolder("48b93769-1947-482b-8343-e612d58a9655")]
        public partial class ProductDetailAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _someimgtagInfo;
            RepoItemInfo _httpscdndsmcdncomty329productmedInfo;
            RepoItemInfo _httpscdndsmcdncomty55productmediInfo;
            RepoItemInfo _sepeteekleInfo;

            /// <summary>
            /// Creates a new ProductDetailApp  folder.
            /// </summary>
            public ProductDetailAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ProductDetailApp", ".//main[#'product-detail-app']", parentFolder, 30000, null, false, "48b93769-1947-482b-8343-e612d58a9655", "")
            {
                _someimgtagInfo = new RepoItemInfo(this, "SomeImgTag", "?/?/aside[1]/div[2]/div/div/div/div[8]/?/?/a/?/?/img", ".//img", 30000, null, "62dae6ab-08b2-4a3a-879e-838b4373c6d2");
                _httpscdndsmcdncomty329productmedInfo = new RepoItemInfo(this, "HttpsCdnDsmcdnComTy329ProductMed", "div/aside[1]/div[2]/div/div/div/div[10]/?/?/a[@href>'https://www.trendyol.com/']/?/?/img[@src='https://cdn.dsmcdn.com/ty329/product/media/images/20220209/0/47296945/383427344/1/1_org_thumb.jpg']", ".//img[@src='https://cdn.dsmcdn.com/ty329/product/media/images/20220209/0/47296945/383427344/1/1_org_thumb.jpg']", 30000, null, "09fd58ef-9d5d-460a-a865-62e80016022e");
                _httpscdndsmcdncomty55productmediInfo = new RepoItemInfo(this, "HttpsCdnDsmcdnComTy55ProductMedi", "div/aside[1]/div[2]/div/div/div/div[8]/?/?/a[@href>'https://www.trendyol.com/']/?/?/img[@alt='']", ".//img[@src='https://cdn.dsmcdn.com/ty55/product/media/images/20210112/23/52367057/61525077/1/1_org_thumb.jpg']", 30000, null, "20cdf187-346c-4f6b-a89e-6f4e2f39a49c");
                _sepeteekleInfo = new RepoItemInfo(this, "SepeteEkle", "div/div[2]//button/div[@innertext='Sepete Ekle']", ".//div[@innertext='Sepete Ekle']", 30000, null, "c4223af8-393c-40a0-9dc5-dca9b6c3e1ef");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("48b93769-1947-482b-8343-e612d58a9655")]
            public virtual Ranorex.MainTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MainTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("48b93769-1947-482b-8343-e612d58a9655")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeImgTag item.
            /// </summary>
            [RepositoryItem("62dae6ab-08b2-4a3a-879e-838b4373c6d2")]
            public virtual Ranorex.ImgTag SomeImgTag
            {
                get
                {
                    return _someimgtagInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The SomeImgTag item info.
            /// </summary>
            [RepositoryItemInfo("62dae6ab-08b2-4a3a-879e-838b4373c6d2")]
            public virtual RepoItemInfo SomeImgTagInfo
            {
                get
                {
                    return _someimgtagInfo;
                }
            }

            /// <summary>
            /// The HttpsCdnDsmcdnComTy329ProductMed item.
            /// </summary>
            [RepositoryItem("09fd58ef-9d5d-460a-a865-62e80016022e")]
            public virtual Ranorex.ImgTag HttpsCdnDsmcdnComTy329ProductMed
            {
                get
                {
                    return _httpscdndsmcdncomty329productmedInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The HttpsCdnDsmcdnComTy329ProductMed item info.
            /// </summary>
            [RepositoryItemInfo("09fd58ef-9d5d-460a-a865-62e80016022e")]
            public virtual RepoItemInfo HttpsCdnDsmcdnComTy329ProductMedInfo
            {
                get
                {
                    return _httpscdndsmcdncomty329productmedInfo;
                }
            }

            /// <summary>
            /// The HttpsCdnDsmcdnComTy55ProductMedi item.
            /// </summary>
            [RepositoryItem("20cdf187-346c-4f6b-a89e-6f4e2f39a49c")]
            public virtual Ranorex.ImgTag HttpsCdnDsmcdnComTy55ProductMedi
            {
                get
                {
                    return _httpscdndsmcdncomty55productmediInfo.CreateAdapter<Ranorex.ImgTag>(true);
                }
            }

            /// <summary>
            /// The HttpsCdnDsmcdnComTy55ProductMedi item info.
            /// </summary>
            [RepositoryItemInfo("20cdf187-346c-4f6b-a89e-6f4e2f39a49c")]
            public virtual RepoItemInfo HttpsCdnDsmcdnComTy55ProductMediInfo
            {
                get
                {
                    return _httpscdndsmcdncomty55productmediInfo;
                }
            }

            /// <summary>
            /// The SepeteEkle item.
            /// </summary>
            [RepositoryItem("c4223af8-393c-40a0-9dc5-dca9b6c3e1ef")]
            public virtual Ranorex.DivTag SepeteEkle
            {
                get
                {
                    return _sepeteekleInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The SepeteEkle item info.
            /// </summary>
            [RepositoryItemInfo("c4223af8-393c-40a0-9dc5-dca9b6c3e1ef")]
            public virtual RepoItemInfo SepeteEkleInfo
            {
                get
                {
                    return _sepeteekleInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("a4ab9dc3-b207-4d6a-8f6c-b6d22cba9792")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _ranorexstudio2calışanpencereInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "a4ab9dc3-b207-4d6a-8f6c-b6d22cba9792", "")
            {
                _ranorexstudio2calışanpencereInfo = new RepoItemInfo(this, "RanorexStudio2CalışanPencere", "container[@controlid='40965']//toolbar[@accessiblename='Çalışan uygulamalar']/button[23]", ".//toolbar[@accessiblename='Çalışan uygulamalar']/button[23]", 30000, null, "641a74d7-722f-4406-b29c-ed852eb82d47");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a4ab9dc3-b207-4d6a-8f6c-b6d22cba9792")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a4ab9dc3-b207-4d6a-8f6c-b6d22cba9792")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RanorexStudio2CalışanPencere item.
            /// </summary>
            [RepositoryItem("641a74d7-722f-4406-b29c-ed852eb82d47")]
            public virtual Ranorex.Button RanorexStudio2CalışanPencere
            {
                get
                {
                    return _ranorexstudio2calışanpencereInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RanorexStudio2CalışanPencere item info.
            /// </summary>
            [RepositoryItemInfo("641a74d7-722f-4406-b29c-ed852eb82d47")]
            public virtual RepoItemInfo RanorexStudio2CalışanPencereInfo
            {
                get
                {
                    return _ranorexstudio2calışanpencereInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
