﻿namespace MusicShopManager.Engine.Factories
{
    using System;
    using MusicShopManager.Interfaces;
    using MusicShopManager.Interfaces.Engine;
    using MusicShopManager.Models;
    using MusicShop.Models;

    public class ArticleFactory : IArticleFactory
    {
        public IMicrophone CreateMirophone(string make, string model, decimal price, bool hasCable)
        {
            Microphone microphone = new Microphone(make, model, price, hasCable);
            return microphone;
        }

        public IDrums CreateDrums(string make, string model, decimal price, string color, int width, int height)
        {
            Drums drums = new Drums(make, model, price, color, width, height);
            return drums;
        }

        public IElectricGuitar CreateElectricGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
        {
            ElectricGuitar electricGuitar = new ElectricGuitar(make, model, price, color, bodyWood, fingerboardWood, numberOfAdapters, numberOfFrets);
            return electricGuitar;
        }

        public IAcousticGuitar CreateAcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
        {
            AcousticGuitar acousticGuitar = new AcousticGuitar(make, model, price, color,
            bodyWood, fingerboardWood, caseIncluded, stringMaterial);
            return acousticGuitar;

        }

        public IBassGuitar CreateBassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
        {
            BassGuitar bassGuirat = new BassGuitar(make, model, price, color, bodyWood, fingerboardWood);
            return bassGuirat;
        }
    }
}
