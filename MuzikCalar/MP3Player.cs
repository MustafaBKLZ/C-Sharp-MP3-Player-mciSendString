using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace MuzikCalar
{
    class MP3Player
    {
        private string PlayerCommand;
        private bool muzikAcik = false;
        private bool muzikCaliyor = false;
        public bool muzikDuraklatildi = false;

        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, int OlmazsaOlmaz);

        public MP3Player()
        {
        }

        /// <SUMMARY>
        /// Çalan müziği durdur. Kaldığı yerden devam etmez.
        /// </SUMMARY>
        public void mp3_Kapat()
        {
            PlayerCommand = "close MediaFile";
            mciSendString(PlayerCommand, null, 0, 0);
            muzikAcik = false;
        }

        /// <SUMMARY>
        /// Yeni bir müzik dosyası aç
        /// </SUMMARY>
        /// <param name="sFileName" />Müzik yolu</param />
        public void mp3_Ac(string sFileName)
        {
            PlayerCommand = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            mciSendString(PlayerCommand, null, 0, 0);
            muzikAcik = true;
        }

        /// <SUMMARY>
        /// Seçilen müziği oynat.
        /// </SUMMARY>
        /// <param name="loop" />True gelirse kendini tekrarlar.</param />
        public void mp3_Oynat(bool loop)
        {
            if (muzikAcik)
            {
                PlayerCommand = "play MediaFile";
                if (loop)
                    PlayerCommand += " REPEAT";
                mciSendString(PlayerCommand, null, 0, 0);
                muzikCaliyor = true;

            }
        }

        /// <SUMMARY>
        /// Müziği duraklat.
        /// </SUMMARY>
        public void mp3_Duraklat()
        {
            PlayerCommand = "pause MediaFile";
            mciSendString(PlayerCommand, null, 0, 0);
            muzikDuraklatildi = true;
        }

        /// <SUMMARY>
        /// Müziğin son durumunu alır. Çalıyor, Duraklatıldı vs.
        /// </SUMMARY>
        public string mp3_Durum()
        {
            int i = 128;
            StringBuilder str = new StringBuilder(i);
            mciSendString("status MediaFile mode", str, i, 0);
            switch (str.ToString())
            {
                case "playing":
                    return "Çalıyor";
                case "paused":
                    return "Duraklatıldı";
                default:
                    return "Kapatıldı";
            }
        }

        /// <SUMMARY>
        /// Müziğin Sol Sesini Ayarla
        /// </SUMMARY>
        public int SolSes
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile left volume to ", value), null, 0, 0);
            }
        }

        /// <SUMMARY>
        /// Müziğin Sağ Sesini Ayarla
        /// </SUMMARY>
        public int SagSes
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile right volume to ", value), null, 0, 0);
            }
        }

        /// <SUMMARY>
        /// Müziğin Ana Sesini Ayarla
        /// </SUMMARY>
        public int AnaSes
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile volume to ", value), null, 0, 0);
            }
        }

        /// <SUMMARY>
        /// Müziğin Bas Sesini Ayarla
        /// </SUMMARY>
        public int Bass
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile bass to ", value), null, 0, 0);
            }
        }

        /// <SUMMARY>
        /// Müziğin Tiz Sesini Ayarla
        /// </SUMMARY>
        public int Tiz
        {
            get
            {
                return 0;
            }
            set
            {
                mciSendString(string.Concat("setaudio MediaFile treble to ", value), null, 0, 0);
            }
        }


        public TimeSpan _ts_Pozisyon;
        private double _ms_Pozisyon = 0;
        public int _sn_Pozisyon = 0;
        public string _st_Pozisyon = "";
        /// <summary>
        /// Şuanda oynatılan müziğin kacıncı saniyesinde olduğunu bulur.
        /// </summary>
        public void Pozisyon()
        {
            if (muzikAcik && muzikCaliyor)
            {
                StringBuilder str = new StringBuilder(128);
                PlayerCommand = "status MediaFile position";
                mciSendString(PlayerCommand, str, 128, 0);
                try
                {
                    _ms_Pozisyon = Convert.ToDouble(str.ToString());
                }
                catch (FormatException) { }
                try
                {
                    _sn_Pozisyon = Convert.ToInt32(TimeSpan.FromMilliseconds(_ms_Pozisyon).TotalSeconds);

                    _ts_Pozisyon = TimeSpan.FromMilliseconds(_ms_Pozisyon);
                    _st_Pozisyon = string.Format("{0:D2}:{1:D2}:{2:D2}",
                       _ts_Pozisyon.Hours,
                       _ts_Pozisyon.Minutes,
                       _ts_Pozisyon.Seconds);
                }
                catch (InvalidCastException) { }
            }
        }

        private TimeSpan _ts_ToplamSure;
        private double _ms_ToplamSure = 0;
        public int _sn_ToplamSure = 0;
        public string _st_ToplamSure = "";
        /// <summary>
        /// Şuanda oynatılan müziğin süresini bulur
        /// </summary>
        public void ToplamSure()
        {
            if (muzikAcik && muzikCaliyor)
            {
                StringBuilder str = new StringBuilder(128);
                PlayerCommand = " status MediaFile length";
                mciSendString(PlayerCommand, str, 128, 0);
                try
                {
                    _ms_ToplamSure = Convert.ToDouble(str.ToString());
                }
                catch (FormatException) { }
                try
                {
                    _sn_ToplamSure = Convert.ToInt32(TimeSpan.FromMilliseconds(_ms_ToplamSure).TotalSeconds);

                    _ts_ToplamSure = TimeSpan.FromMilliseconds(_ms_ToplamSure);
                    _st_ToplamSure = string.Format("{0:D2}:{1:D2}:{2:D2}",
                       _ts_ToplamSure.Hours,
                       _ts_ToplamSure.Minutes,
                       _ts_ToplamSure.Seconds);
                }
                catch (InvalidCastException) { }
            }
        }

        /// <summary>
        /// Müziği ileri yada geri sar
        /// </summary>
        public void IleriGeriSar(double ms)
        {
            mciSendString("seek MediaFile to " + ms, null, 0, 0);
        }

    }
}