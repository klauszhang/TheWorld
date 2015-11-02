(function () {

  var $sidebarAndWarpper = $("#sidebar, #warpper");

  $("#sidebarToggle").on("click", function () {
    $sidebarAndWarpper.toggleClass("hide-sidebar");
    if ($sidebarAndWarpper.hasClass("hide-sidebar")) {
      $(this).text("Show Sidebar");
    }
    else {
      $(this).text("Hide Sidebar");
    }
  });


})();