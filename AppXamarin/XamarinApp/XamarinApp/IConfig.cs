using SQLite.Net.Interop;
using System;

namespace XamarinApp
{
    public interface IConfig
    {
        string DirectorioDB { get; }
        ISQLitePlatform Plataforma { get; }
    }

}
