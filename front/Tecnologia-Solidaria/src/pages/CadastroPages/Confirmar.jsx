import React from 'react'
import "./CadastroEmpresaCSS.css"
import ImagemFundo from "../../assets/Saly-12.png";
import { useParams, Link} from 'react-router-dom';
import axios from 'axios';
export default function Confirmar() {
    const {dado, nome} = useParams();

    const deletardados = async (e) => {
        //para n mostrar tudo no link
        e.preventDefault();
    
        if(dado.length == 11){
         await axios.delete(`https://localhost:7126/api/Cliente/deleteFisico/${dado}`);
        }else if(dado.length == 14){
         await axios.delete(`https://localhost:7126/api/Cliente/deleteJuritico/${dado}`);
        }
        
        //nessa caso, a pagina inicial
        navigate(`/`)
    } 
  return (
    <section className="container-fluid sect-form">
      {/* <!-- imagem de fundo --> */}
      <div className="img-back">
          <img src={ImagemFundo} />
      </div>
  
      <main className="main-form-geral">
  
  
      {/* <!-- titulo --> */}
          <h3>Cadastro feito!</h3>

          <form className="form-pessoa" id="frmEscolha">
            <p style={{color: "black",fontFamily: "var(--font-titulo)", fontWeight: "900"}}>Obrigado por acreditar em nós! Mas, {nome}, caso queira cancelar, basta apertar em cancelar </p>
              <div className="div-input">
                               
                <Link to="/" className="ancora-escolha btn-danger " id="escolha-1">voltar para Home</Link>
                <button className="ancora-escolha btn-success " id="escolha-2" onClick={(e) => deletardados(e)}>Cancelar</button>
                
              </div>
          </form>
      </main>
    </section>
  )
}
