import React from 'react'
import Header from "../components/Header"
import FlipCard from "../components/FlipCard"
import "./HomePageCSS.css"

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
                back={"Levar a tecnologia até as pessoas que não são alcançadas afim de diminuir a desigualdade na educação de alunos menos favorecidas, em zonas rurais para diminuir a exclusão digital"}/>
              </div>
              {/* <!-- COLUNA 2 --> */}
             <div class="col-sm main-col">
                <FlipCard 
                front={"Visão"} 
                back={"Ser um projeto reconhecido pelo Brasil inteiro, diminuir de forma expansiva a dificuldade de acessos a tecnologia, e difundir a ideia de ajudar alguem é da asas ao futuro dessa pessoa"} />
             </div>
             {/* <!-- COLUNA 3 --> */}
             <div class="col-sm main-col">
                <FlipCard 
                front={"Valores"} 
                back={"Integridade, qualidade, responsabilidade, compromisso e transparência."}/>
             </div>
            </div>
          </main>
      </section>
    </>
  )
}
