/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;
using Sample.IViewModels;

namespace Sample.ViewModels
{
    public class ImageResourceExtensionViewModel : IImageResourceExtensionViewModel
    {
        public String MyResource
        {
            get
            {
                return "AppResources.Assets";
            }
        }
    }
}
