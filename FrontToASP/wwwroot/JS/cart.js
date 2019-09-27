"use strict";
/*comentde olanlar chatdirmadigim hissedir hansi ki, silinende cart update olmali idi,
 bir de AddToCart ancaq chatdirdim, BuyNow click chatdirmadim. 
 vee bir biyabirliq var add to cart ancaq endirimde olani locala atir
  evvelden sehv yazmishdim Samir muellim bilir hamisin silib yazmaga chatdirmazdim deye
   ve local storage bacariram hiss eledirmek uchun
    bu varianta vaxt serf eledim, uzr isteyirem./*/
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
});
const basket = JSON.parse(localStorage.getItem("basket"));
//$(".clearZero").text("[" +(2+ basket.length) + "]");
//Agil backTick sevir deye
$(".clearZero").text(`[${2 + basket.length}]`);

let checkoutBasket = document.getElementsByClassName("checkoutBasket")[0];
let checkoutProduct;
let imgTd;
let productImg;
let productImgWrapper;
let infoTd;
let productInfo;
let moreInfo;
let priceTd;
let productPrice;
let totalTd;
let totalPrices;
let iconTd;
let iconWrapperSpan;
let inputTd;
let myInput;
let checkoutProductSelect;
if (basket.length != 0) {
  basket.forEach(function(element) {
    checkoutProduct = document.createElement("tr");
    iconTd = document.createElement("td");
    iconWrapperSpan = document.createElement("span");
    iconWrapperSpan.classList.add("iconWrapper");
    iconWrapperSpan.innerHTML = '<i class="fas fa-times"></i>';
    iconTd.appendChild(iconWrapperSpan);
    checkoutProduct.appendChild(iconTd);
    imgTd = document.createElement("td");
    productImg = document.createElement("img");
    productImg.setAttribute("src", element.src);
    productImgWrapper = document.createElement("div");
    productImg.classList.add("imgWrapper");
    productImgWrapper.appendChild(productImg);
    imgTd.appendChild(productImgWrapper);
    checkoutProduct.appendChild(imgTd);
    infoTd = document.createElement("td");
    productInfo = document.createElement("h4");
    productInfo.innerText = element.name;
    moreInfo = document.createElement("p");
    moreInfo.innerText =
      "Far far away, behind the word mountains, far from the countries";
    infoTd.appendChild(productInfo);
    infoTd.appendChild(moreInfo);
    checkoutProduct.appendChild(infoTd);
    priceTd = document.createElement("td");
    priceTd.innerText = element.price;
    checkoutProduct.appendChild(priceTd);
    inputTd = document.createElement("td");
    myInput = document.createElement("input");
    myInput.type = "number";
    myInput.value = 1;
    inputTd.appendChild(myInput);
    checkoutProduct.appendChild(inputTd);
    totalTd = document.createElement("td");
    totalTd.innerText = element.price;
    checkoutProduct.appendChild(totalTd);
    checkoutBasket.appendChild(checkoutProduct);
  });
}
const forSelect = [...document.querySelectorAll(".checkoutProduct")];
forSelect.forEach(function(newList) {
  newList.onclick = function() {
    this.classList.toggle("active");
    // this.classList.add("deleted");
  };
});
let forDelete = [...document.querySelectorAll(".iconWrapper")];
// let removeSelected;
// let deleteSelected;
forDelete.forEach(function(element) {
  element.onclick = function() {
    // removeSelected = [...document.getElementsByClassName("active")];
    // deleteSelected = [...document.getElementsByClassName("deleted")];
    // removeSelected.forEach(selecteds => {
    this.parentElement.parentElement.remove();
    // selecteds.remove();
    // });
    // localStorage.removeItem("basket");
    // checkoutBasket.remove();
    // newBasketMaker();
  };
});

// function newBasketMaker() {
//   const selected = document.querySelectorAll(".checkoutProduct");
//   localStorage.setItem("newBasket", JSON.stringify([]));
//   let newBasket;
//   selected.forEach(shippingProduct => {
//     console.log(shippingProduct.firstChild.firstChild.getAttribute("src"));

//     const selectedProImg = shippingProduct.firstChild.firstChild.getAttribute(
//       "src"
//     );
//     console.log(shippingProduct.lastChild.innerText);

//     const selectedProInfo = shippingProduct.lastChild.innerText;

//     const selectedProduct = {
//       img: selectedProImg,
//       info: selectedProInfo
//     };
//     newBasket = JSON.parse(localStorage.getItem("newBasket"));
//     const basketParsed = JSON.parse(localStorage.getItem("newBasket"));
//     basketParsed.push(selectedProduct);
//     localStorage.setItem("newBasket", JSON.stringify(basketParsed));
//     basketCart.querySelector("span").innerText = newBasket.length;
//   });
//   const newCheckoutBasket = document.createElement("ul");
//   newCheckoutBasket.classList.add("checkoutBasket");
//   // let totalPrices;
//   newBasket.forEach(element => {
//     checkoutProduct = document.createElement("li");
//     SrcImgWapper = document.createElement("div");
//     SrcImgWapper.classList.add("SrcImgWapper");
//     productImg = document.createElement("img");
//     productImg.setAttribute("src", element.img);
//     SrcImgWapper.appendChild(productImg);
//     checkoutProduct.appendChild(SrcImgWapper);
//     productInfo = document.createElement("p");
//     checkoutProduct.appendChild(productInfo);
//     productInfo.innerText = element.info;
//     checkoutProduct.classList.add("checkoutProduct");
//     newCheckoutBasket.appendChild(checkoutProduct);
//     // element.price=number(element.price);
//     // totalPrices = totalPrices + element.price;
//   });
//   document.body.appendChild(newCheckoutBasket);
//   const checkoutProductTotal = document.createElement("li");
//   checkoutProductTotal.classList.add("checkoutProductTotal");
//   newCheckoutBasket.appendChild(checkoutProductTotal);
//   const totalInfo = document.createElement("p");
//   totalInfo.innerText = "Total: " + "198" + "$";
//   checkoutProductTotal.appendChild(totalInfo);
//   checkoutProductTotal.classList.add("checkoutProductTotal");
//   checkoutProductSelect = document.createElement("li");
//   checkoutProductSelect.classList.add("checkoutProductSelect");
//   checkoutProductSelect.innerHTML = "<i class='fas fa-trash-alt'></i>";
//   newCheckoutBasket.appendChild(checkoutProductSelect);
//   const forSelect = document.querySelectorAll(".checkoutProduct");
//   forSelect.forEach(newList => {
//     newList.onclick = function() {
//       this.classList.toggle("active");
//     };
//   });
//   checkoutProductSelect.onclick = function() {
//     const removeSelected = document.querySelectorAll(".checkoutProduct.active");
//     removeSelected.forEach(selecteds => {
//       selecteds.remove();
//     });
//     localStorage.removeItem("basket");
//     newBasketMaker();
//   };
// }
