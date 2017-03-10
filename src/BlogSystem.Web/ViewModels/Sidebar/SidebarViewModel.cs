﻿namespace BlogSystem.Web.ViewModels.Sidebar
{
    using System.Collections.Generic;
    using Posts;
    using Pages;

    public class SidebarViewModel
    {
        public IEnumerable<PostViewModel> RecentPosts { get; set; }

        public IEnumerable<PageViewModel> AllPages { get; set; }
    }
}