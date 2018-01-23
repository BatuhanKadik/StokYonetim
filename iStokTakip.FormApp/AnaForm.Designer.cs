namespace iStokTakip.FormApp
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.barBtnStokKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokListe = new DevExpress.XtraBars.BarButtonItem();
            this.barnBtnStokGrup = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokHareket = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 433);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(743, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stok";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokKarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokListe);
            this.ribbonPageGroup1.ItemLinks.Add(this.barnBtnStokGrup);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokHareket);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Stok İşlemleri";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // barBtnStokKarti
            // 
            this.barBtnStokKarti.Caption = "Stok Kartı";
            this.barBtnStokKarti.Id = 1;
            this.barBtnStokKarti.ImageOptions.LargeImage = global::iStokTakip.FormApp.Properties.Resources.Stok_Kartı32x32;
            this.barBtnStokKarti.Name = "barBtnStokKarti";
            this.barBtnStokKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokKarti_ItemClick);
            // 
            // barBtnStokListe
            // 
            this.barBtnStokListe.Caption = "Stok Listesi";
            this.barBtnStokListe.Id = 2;
            this.barBtnStokListe.ImageOptions.LargeImage = global::iStokTakip.FormApp.Properties.Resources.Stok_Liste32x32;
            this.barBtnStokListe.Name = "barBtnStokListe";
            this.barBtnStokListe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokListe_ItemClick);
            // 
            // barnBtnStokGrup
            // 
            this.barnBtnStokGrup.Caption = "Stok Grupları";
            this.barnBtnStokGrup.Id = 3;
            this.barnBtnStokGrup.ImageOptions.LargeImage = global::iStokTakip.FormApp.Properties.Resources.Stok_Grup32x32;
            this.barnBtnStokGrup.Name = "barnBtnStokGrup";
            this.barnBtnStokGrup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barnBtnStokGrup_ItemClick);
            // 
            // barBtnStokHareket
            // 
            this.barBtnStokHareket.Caption = "Stok Hareketleri";
            this.barBtnStokHareket.Id = 4;
            this.barBtnStokHareket.ImageOptions.LargeImage = global::iStokTakip.FormApp.Properties.Resources.Stok_Hareket32x32;
            this.barBtnStokHareket.Name = "barBtnStokHareket";
            this.barBtnStokHareket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokHareket_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "Temalar";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Group1";
            this.skinRibbonGalleryBarItem1.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.skinRibbonGalleryBarItem1.Id = 5;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnStokKarti,
            this.barBtnStokListe,
            this.barnBtnStokGrup,
            this.barBtnStokHareket,
            this.skinRibbonGalleryBarItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.QuickToolbarItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1});
            this.ribbon.Size = new System.Drawing.Size(743, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 464);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Stok Takip v1.0";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barBtnStokKarti;
        private DevExpress.XtraBars.BarButtonItem barBtnStokListe;
        private DevExpress.XtraBars.BarButtonItem barnBtnStokGrup;
        private DevExpress.XtraBars.BarButtonItem barBtnStokHareket;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
    }
}