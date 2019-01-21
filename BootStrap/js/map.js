angular.module('MapApp')
  .controller('MapCtrl', function ($scope) {

    $scope.map = {
      // マップ初期表示の中心地
      center: { 
        latitude: 35.457624,
        longitude: 139.633337
      }, 
      // マップ初期表示の拡大
      zoom: 16
      /** はまったポイント
      *　この中にmarkesの配列を作れば良いということになっていた
      **/
    };

    // マップ上に表示するマーカーの情報
    $scope.markers = [
      {
        /** はまったポイント
        * この「id」という項目がなければ表示されなかった
        **/
        "id":1,
        "latitude":35.459923,
        "longitude":139.635290,
        "title":"パシフィコ横浜"
      },
      {
        "id":2,
        "latitude":35.457511,
        "longitude":139.632704,
        "title":"みなとみらい駅"
      }
    ];
  });