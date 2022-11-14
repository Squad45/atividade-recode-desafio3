import React from 'react'
import imagemI from "../../../assets/img-projeto/img-projeto.jpg"
import imagemII from "../../../assets/img-projeto/img-projeto2.jpg";

import "./style.css"
export default function index() {
  return (
    <article>
            <h3 className="titulo">O que nos motivou</h3>
            <div className="row">
              <div className="col-sm">
                <div className="div-article">
                  <p>
                    No Brasil, 42% das casas não possuem computador e 33% não tem acesso à internet. Dos 3,6 milhões de estudantes da rede estadual de São Paulo, apenas 60% tem notebooks e 30% tem tablets, de acordo com questionário socioeconômico do Sistema de Avaliação de Rendimento Escolar do Estado de São Paulo (SARESP) de 2019.
                  </p>
                </div>

                <div className="div-article">
                  <p>
                    Com as aulas acontecendo remotamente, o Brasil pôde notar as desigualdades de acesso à tecnologia no território nacional. O relatório do IBGE apresenta que no grupo de 15 a 17 anos, apenas 54% possuíam computador ou notebook e acesso à internet em casa durante as aulas remotas. Do total de estudantes elegíveis ao grupo, os pertencentes à rede particular de ensino, 90% possuem acesso à tecnologia necessária para realização das atividades escolares remotas. Já na rede pública, apenas 48,6% tinham computador e internet em casa.
                  </p>
                  <small className="text-muted"><a href="(https://www.poder360.com.br/brasil/55-dos-alunos-nao-tinham-acesso-a-internet-em-aulas-remotas-diz-ibge/)">www.poder360.com.br</a></small>
                </div>
              </div>

              <div className="col-sm img-projeto">
               <img src={imagemI} alt="" width="100%" height="400px" />
              </div>
            </div>
            <div className="row">
                <div className="col-sm img-projeto">
                  <img src={imagemII} alt="" width="100%" height="400px" />
                </div>  
                <div className="col-sm">
                  <div className="div-article">
                    <p>
                      Houve um leve crescimento no número de alunos com computador desde o início da pandemia, de 42% para 49%, contudo, a maior parte (51%) segue sem acesso à computador ou notebook com internet para estudar. O equipamento mais usado é o celular (85%), porém, sabe-se que o aparelho limita as possibilidades de aprendizado do aluno. Mais de um terço (34%) dos estudantes que utilizam o aparelho para fazer as atividades o dividem com outras pessoas, segundo seus responsáveis. Para 27% dos estudantes, a escola é o principal local onde se tem acesso a computadores.
                    </p>
                    <small className="text-muted"><a href="https://blogdopedlowski.com/2021/11/11/87-dos-pais-e-responsaveis-acreditam-que-a-tecnologia-contribuiu-na-aprendizagem-na-pandemia-mas-51-dos-alunos-nao-tem-computador-ou-notebook-com-acesso-a-internet/">blogdopedlowski.com</a></small>
                  </div>  

                  <div className="div-article">
                    <p>
                      Não é muito fácil se livrar desse tipo de lixo. Segundo relatório "Global E-Waste Monitor 2017", foram gerados 44,7 milhões de toneladas de lixo eletrônico em 2016 em todo o mundo. Desse montante, apenas 20%, ou 8,9 milhões de toneladas, foram reciclados. O estudo, divulgado no fim do ano passado, foi produzido pela UIT (órgão da ONU para telecomunicações), a universidade da ONU e a Associação Internacional de Resíduos Sólidos (ISWA, na sigla em inglês).
                    </p>
                    <small><a href="https://www.uol.com.br/tilt/noticias/redacao/2018/06/26/o-que-fazer-com-os-aparelhos-eletronicos-encostados-na-sua-casa.htm">www.uol.com.br</a></small>
                  </div>
                </div>
            </div>
          </article>
  )
}
