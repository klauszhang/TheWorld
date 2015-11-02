(function () {

  var $sidebarAndWarpper = $("#sidebar, #warpper");
  var $icon = $("#sidebarToggle i.fa");

  $("#sidebarToggle").on("click", function () {
    $sidebarAndWarpper.toggleClass("hide-sidebar");
    if ($sidebarAndWarpper.hasClass("hide-sidebar")) {
      $icon.removeClass("fa-angle-left");
      $icon.addClass("fa-angle-right");

    }
    else {
      $icon.removeClass("fa-angle-right");
      $icon.addClass("fa-angle-left");
    }
  });


})();