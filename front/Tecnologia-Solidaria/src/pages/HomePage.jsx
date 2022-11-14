import React from "react";

import Header from "../components/HomePage/Header";
import FlipCard from "../components/HomePage/FlipCard";
import ItemExpo from "../components/HomePage/ItemExposicao";


import Bradesco from "../assets/img-logos/bradesco-logo1.png";
import Intel from "../assets/img-logos/logo-intel1.jpg";
import Positivo from "../assets/img-logos/Logo-Positivo1.jpg";
import Recode from "../assets/img-logos/recode-logos.svg";

import "./HomePageCSS.css";

export default function HomePage() {
  return (
    <>
      <Header />

      <section className="container texto-explicativo" id="texto-explicativo">
        <main className="main-1">
          <div className="row row-flex">
            {/* <!-- COLUNA 1 --> */}
            <div className="col-sm main-col">
              <FlipCard
                front={"Missão"}
                back={
                  "Levar a tecnologia até as pessoas que não são alcançadas afim de diminuir a desigualdade na educação de alunos menos favorecidas, em zonas rurais para diminuir a exclusão digital"
                }
              />
            </div>
            {/* <!-- COLUNA 2 --> */}
            <div class="col-sm main-col">
              <FlipCard
                front={"Visão"}
                back={
                  "Ser um projeto reconhecido pelo Brasil inteiro, diminuir de forma expansiva a dificuldade de acessos a tecnologia, e difundir a ideia de ajudar alguem é da asas ao futuro dessa pessoa"
                }
              />
            </div>
            {/* <!-- COLUNA 3 --> */}
            <div class="col-sm main-col">
              <FlipCard
                front={"Valores"}
                back={
                  "Integridade, qualidade, responsabilidade, compromisso e transparência."
                }
              />
            </div>
          </div>
        </main>
      </section>

      {/* <!-- área de exposição --> */}
      <section class="container-fluid apresentação-empresa">
        <main class="main-2">
          <h3 class="titulo">Empresas que acreditam no nosso projeto</h3>

          {/* <!-- apenas exemplos,demonstração ainda. --> */}
          <div class="row">

            <ItemExpo imagem={Bradesco} titulo={"Bradesco"} />
            <ItemExpo imagem={Positivo} titulo={"Positivo"} />
            <ItemExpo imagem={Intel} titulo={"Intel"} />
            <ItemExpo imagem={Recode} titulo={"Recode"} />

          </div>
        </main>
      </section>

      
    </>
  );
}
