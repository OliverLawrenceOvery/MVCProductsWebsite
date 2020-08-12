import React from 'react';
import ReactDOM from 'react-dom';
import './style.css';


const element = (
    <div className="main">
        <section className="banner">
            <img src="/Content/background.jpg" className="fitBg"></img>
            <div className="content">
                <h2>Welcome</h2>
                <p>
                    Welcome to our products page
                </p>
                <a href='#about' className="btn">Learn More About Our Products</a>
            </div>
        </section>
    </div>
);

const element2 = (
    <div className="main">
        <section className="about" id="about">
            <div className="contentBx">
                <h2 className="titleText">About Us</h2>
                <p className="text">
                    We have many products to choose from. Look at this phone on the right.
                </p>
                <a href="#destination" className="btn">Popular Products</a>
            </div>
            <div className="imgBx">
                <img src="/Content/phone.jpg" className="fitBg"></img>
            </div>
        </section>
    </div>
);

const element3 = (
    <div className="main">
        <section className="banner2">
            <img src="/Content/background2.jpg" className="fitBg"></img>
        </section>
    </div>
);

const element4 = (
    <div className="main">
        <section className="destination" id="destination">
            <div className="content">
                <h2 className="titleText">Our Products</h2>
                <p className="text">
                    Some of our most popular products are shown below
                </p>
            </div>
            <div className="destinationList">

                <div className="box">
                    <div className="imgBx" >
                        <img src="/Content/car.jpg" className="fitBg"></img>
                    </div>
                    <div className="content">
                        <h2>Car
                       <br></br>
                            <span>
                                It's a mini metro
                            </span>
                        </h2>
                    </div>
                </div>

                <div className="box">
                    <div className="imgBx" >
                        <img src="/Content/phones.jpg" className="fitBg"></img>
                    </div>
                    <div className="content">
                        <h2>Phones
                       <br></br>
                            <span>
                                These are some phones
                            </span>
                        </h2>
                    </div>
                </div>

                <div className="box">
                    <div className="imgBx" >
                        <img src="/Content/bike.jpg" className="fitBg"></img>
                    </div>
                    <div className="content">
                       <h2>Bike
                       <br></br>
                            <span>
                                It's a bike
                            </span>
                        </h2>
                    </div>
                </div>

            </div>
        </section>
    </div>
);

const footer = (
    <div className="main">
        <section className="footer">
            <ul className="sci">
                <li><a href='#'><img src="/Content/facebook.png"></img></a></li>
                <li><a href='#'><img src="/Content/twitter.png"></img></a></li>
                <li><a href='#'><img src="/Content/instagram.png"></img></a></li>
            </ul>
        </section>
    </div>
);


ReactDOM.render(element, document.getElementById('root'));
ReactDOM.render(element2, document.getElementById('root2'));
ReactDOM.render(element3, document.getElementById('root3'));
ReactDOM.render(element4, document.getElementById('root4'));
ReactDOM.render(footer, document.getElementById('reactFooter'));
