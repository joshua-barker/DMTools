function openTab(evt, cityName) {
    // Declare all variables
    var i, tabcontent, tablinks;

    // Get all elements with class="tab-content" and hide them
    tabcontent = document.getElementsByClassName("tab-content");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Get all elements with class="tab-links" and remove the class "active"
    tablinks = document.getElementsByClassName("tab-links");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(cityName).style.display = "block";
    evt.currentTarget.className += " active";
}

$(function () {
    $(".table-slide").find("div").hide();
    $("table").click(function (event) {
        event.stopPropagation();
        var $target = $(event.target);
        if ($target.hasClass("no-click"))
        {
            return;
        }
        console.log($target);
        if ($target.closest("td").attr("colspan") > 1) {
            $target.slideUp();
        }
        else
        {
            $target.closest("tr").next().find("div").slideToggle();
        }
    });
});