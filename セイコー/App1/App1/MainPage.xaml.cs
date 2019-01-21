using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace App1
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int count;
        DispatcherTimer timer = new DispatcherTimer();

        public MainPage()
        {
            this.InitializeComponent();

            TimeCount();

            //GetGeopositionAsync();

            //SetGeolocatorAsync();

        }

        /// <summary>
        /// 一定処理
        /// <param name=""></param>
        /// </summary>
        private void TimeCount()
        {

            timer.Interval = TimeSpan.FromMilliseconds(1000);

            this.timer.Tick += (sender, e) =>
            {
                Debug.WriteLine("Tick : " + DateTime.Now);
            };

            this.timer.Start();

        }

        /// <summary>
        /// Geolocationによる位置情報取得
        /// <param name=""></param>
        /// </summary>
        private async void GetGeopositionAsync()
        {
            var geolocator = new Windows.Devices.Geolocation.Geolocator();

            try
            {


                var timeout = TimeSpan.FromSeconds(30);

                // 現在の位置情報を取得する
                var pos = await geolocator.GetGeopositionAsync(
                    );

                // 現在位置の国名を取得する
                //var country = pos.CivicAddress.Country;

                // 現在位置の郵便番号を取得する
                //var postalCode = pos.CivicAddress.PostalCode;

                // 測位した現在地の精度を取得する(単位：メートル)
                var accuracy = pos.Coordinate.Accuracy;

                // 現在の経度を取得する
                var position = pos.Coordinate.Point.Position;
                var longitude = position.Longitude;

                // 現在の緯度を取得する
                var latitude = position.Latitude;

                // 現在の高度を取得する
                var altitude = position.Altitude;

                //Debug.WriteLine("country:{0}", country);
                //Debug.WriteLine("postalCode:{0}", postalCode);
                Debug.WriteLine("accuracy:{0}", accuracy);
                Debug.WriteLine("longitude:{0}", longitude);
                Debug.WriteLine("latitude:{0}", latitude);
                Debug.WriteLine("altitude:{0}", altitude);

                Val1_T.Text = "現在地の精度";
                Val1.Text = accuracy.ToString();

                Val2_T.Text = "現在の緯度";
                Val2.Text = latitude.ToString();

                Val3_T.Text = "現在の経度";
                Val3.Text = longitude.ToString();

                Val4_T.Text = "現在の高度";
                Val4.Text = altitude.ToString();


                // 出力結果
                // country:JP
                // postalCode:
                // accuracy:350
                // longitude:139.573199
                // latitude:35.658944
                // altitude:0
            }
            catch (System.UnauthorizedAccessException)
            {
                // 失敗：マニフェストで「場所」の機能が有効になっていない
                // ユーザーがランタイムから「場所」をアクセスするのを拒否している
            }
            catch (TaskCanceledException)
            {
                // 失敗：キャンセルされたか、タイムアウトしました
            }
        }

        /// <summary>
        /// Xamarin.Formsプラグインによる位置情報取得
        /// <param name=""></param>
        /// </summary>
        private async void SetGeolocatorAsync()
        {
            var timeout = TimeSpan.FromSeconds(30);

            IGeolocator locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50; // <- 1. 50mの精度に指定

            Position position = await locator.GetPositionAsync(timeout);

        }

        /// <summary>
        /// 一定処理
        /// <param name=""></param>
        /// </summary>
        private void SetCount()
        {
            this.Count_T.Text = "カウント";

            if (!timer.IsEnabled)
            {

                timer.Interval = TimeSpan.FromSeconds(1);


                timer.Tick += timer_Tick;

                timer.Start();

                this.Count_Val.Text = "0";
            }
            else
            {
                timer.Stop();

                this.count = 0;

                this.Count_Val.Text = "";

                timer = new DispatcherTimer();
            }
        }

        /// <summary>
        /// カウント処理
        /// <param name=""></param>
        /// </summary>
        private void timer_Tick(object sender, object e)
        {
            // カウントを1加算
            this.count++;

            // TextBlockにカウントを表示
            this.Count_Val.Text = this.count.ToString();
        }

        private void Count_Btn_Click(object sender, RoutedEventArgs e)
        {
            SetCount();
        }
    }


}
