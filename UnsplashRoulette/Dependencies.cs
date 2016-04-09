﻿using UnsplashRoulette.Framework;
using UnsplashRoulette.Main;
using UnsplashRoulette.Data;
using UnsplashRoulette.Photos;
using UnsplashRoulette.Photos.Unsplash;

namespace UnsplashRoulette
{
    class Dependencies
    {
        public static void Register(DependencyInjector injector)
        {
            injector.CreateSingleton<ViewResolver, UwpViewResolver>();
            injector.CreateSingleton<Navigator,  UwpNavigator>(typeof(ViewResolver));
            injector.CreateSingleton<HttpService, UwpHttpService>();
            injector.CreateSingleton<Deserialiser, JsonDeserialiser>();
            injector.CreateSingleton<IPhotoService, UnsplashService>(typeof(HttpService), typeof(Deserialiser));

            ViewResolver viewResolver = injector.GetSingleton<ViewResolver>();
            viewResolver.Register<MainViewModel, MainView>();
        }
    }
}