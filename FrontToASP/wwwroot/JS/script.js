"use srtict";
//////////////////////////////////////////////////////
//

window.onload = function() {
  preloader.classList.add("hide");

  setTimeout(() => {
    preloader.classList.add("d-none");
  }, 100);
};
//////////////////////////////////////////////////////
$(document).ready(function() {
  //////////////////////////////////////////////////////
  let $topNAvBar = $(".topNavBar"),
    topNavBarActive = "topNavBarActive",
    activateAtY = 500;
  function deactivateHeader() {
    if (!$topNAvBar.hasClass(topNavBarActive)) {
      $topNAvBar.addClass(topNavBarActive);
    }
  }
  function activateHeader() {
    if ($topNAvBar.hasClass(topNavBarActive)) {
      $topNAvBar.removeClass(topNavBarActive);
    }
  }
  $(window).scroll(function() {
    if ($(window).scrollTop() > activateAtY) {
      deactivateHeader();
    } else {
      activateHeader();
    }
  });
  //////////////////////////////////////////////////////
  let firstOwl = $(".autoPlay");
  firstOwl.owlCarousel({
    items: 1,
    loop: true,
    margin: 10,
    autoplay: true,
    autoplayTimeout: 1500
  });
  $(".play").on("click", function() {
    owl.trigger("play.owl.autoplay", [1000]);
  });
  $(".stop").on("click", function() {
    owl.trigger("stop.owl.autoplay");
  });
  //////////////////////////////////////////////////////
  let secondOwl = $(".loop");
  secondOwl.owlCarousel({
    center: true,
    items: 2,
    loop: true,
    margin: 10,
    responsive: {
      600: {
        items: 4
      }
    }
  });
  //////////////////////////////////////////////////////
  $(".left").click(() => {
    let oldVal = $(".singleProtuctCheckoutInput").val();
    let newVal = +oldVal + 1;
    $(".singleProtuctCheckoutInput").val(newVal);
  });
  $(".right").click(() => {
    let oldVal = $(".singleProtuctCheckoutInput").val();
    let newVal = +oldVal - 1;
    $(".singleProtuctCheckoutInput").val(newVal);
  });
  //////////////////////////////////////////////////////
  if (localStorage.getItem("basket") === null) {
    localStorage.setItem("basket", JSON.stringify([]));
  }
  const basket = JSON.parse(localStorage.getItem("basket"));
  //$(".clearZero").text("[" +(2+ basket.length) + "]");
  //Agil backTick sevir deye
  $(".clearZero").text(`[${2 + basket.length}]`);
  $(".blackButton").click(function(e) {
    e.preventDefault();
    const proSrc = $(this)
      .parents(".imgWrapper")
      .children("img")
      .attr("src");

    const proname = $(this)
      .parents(".col-12")
      .next()
      .children(".h3Normal")
      .text();
    const proprice = $(this)
      .parents(".col-12")
      .next()
      .next()
      .find("span:first-child")[1]
      .nextSibling.nodeValue.replace("$", "");

    console.log(proprice);
    const product = {
      name: proname,
      price: proprice,
      src: proSrc
    };

    const basketParsed = JSON.parse(localStorage.getItem("basket"));

    basketParsed.push(product);
    UpdateCart(basketParsed);

    localStorage.setItem("basket", JSON.stringify(basketParsed));
  });

  function UpdateCart(basket) {
    $(".clearZero").text(`[${2 + basket.length}]`);
  }
  //////////////////////////////////////////////////////
  let a = 0;
  setInterval(() => {
    setInterval(() => {
      if (a < 10000) {
        let newBold = a++;
        $(".happyClient").text(newBold);
      } else {
        $(".happyClient").text("10,000");
      }
    }, 10);
  }, 10);
  let b = 0;
  setInterval(() => {
    if (b < 100) {
      let newBold = b++;
      $(".branches").text(newBold);
    } else {
      $(".branches").text("100");
    }
  }, 10);
  let c = 0;
  setInterval(() => {
    setInterval(() => {
      if (c < 1000) {
        let newBold = c++;
        $(".partiner").text(newBold);
      } else {
        $(".partiner").text("1,000");
      }
    }, 100);
  }, 10);
  let d = 0;
  setInterval(() => {
    if (d < 100) {
      let newBold = d++;
      $(".awards").text(newBold);
    } else {
      $(".awards").text("100");
    }
  }, 10);
});
