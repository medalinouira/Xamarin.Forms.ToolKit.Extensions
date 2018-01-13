/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using Xamarin.Forms;
using Sample.IViewModels;
using Xamarin.Forms.Navigation;

namespace Sample.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DependencyService.Register<IHomeViewModel, HomeViewModel>();
            DependencyService.Register<ITranslateExtensionViewModel, TranslateExtensionViewModel>();
            DependencyService.Register<IImageResourceExtensionViewModel, ImageResourceExtensionViewModel>();

            DependencyService.Register<INavigationService, NavigationService>();
        }

        public IHomeViewModel Home
        {
            get
            {
                return DependencyService.Get<IHomeViewModel>();
            }
        }

        public ITranslateExtensionViewModel TranslateExtension
        {
            get
            {
                return DependencyService.Get<ITranslateExtensionViewModel>();
            }
        }

        public IImageResourceExtensionViewModel ImageResourceExtension
        {
            get
            {
                return DependencyService.Get<IImageResourceExtensionViewModel>();
            }
        }
    }
}
