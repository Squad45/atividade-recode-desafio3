import React, { useState } from "react";
import "./CadastroEmpresaCSS.css";
import ImagemFundo from "../../assets/Saly-12.png";
import { useNavigate } from "react-router-dom"
import axios from "axios";
import { Link } from "react-router-dom";

export default function CadastroEmpresa() {
  let navigate = useNavigate();
  const [ativo, setAtivo] = useState(false);
  const [ativoII, setAtivoII] = useState(false);
  const [clienteEmp, setClienteEmp] = useState({
    nome: "",
    cnpj: "",
    cargo: "",
    instituicao: "",
    email: "",
    telefone: "",
    escolha: "",
    equipamento: "",
    explicacao: "",
    uf: "",
    cep: "",
    rua: "",
    pontoRef: ""
  });

  const { nome, cnpj, cargo, instituicao, 
    email, telefone, escolha, equipamento, 
    explicacao, uf, cep,rua, pontoRef, } = clienteEmp

  const ChangeVisibility = () => {
    setAtivo(!ativo);
  };
  const showOptions = () => {
    setAtivoII(!ativoII);
  };
  const choice = (e) => {
    setClienteEmp({...clienteEmp, [e.target.name]:e.target.value})
    console.log(escolha)
  }
  const onInputChange = (e) =>{
    setClienteEmp({...clienteEmp, [e.target.name]:e.target.value})
}
const onSubmit = async (e) => {
  //para n mostrar tudo no link
  e.preventDefault();


   await axios.post(`https://localhost:7126/api/Cliente/juridica`, {
    nome: nome,
    cnpj: cnpj,
    cargo: cargo,
    instituicao: instituicao,
    email: email,
    telefone: telefone,
    escolha: escolha,
    equipamento: equipamento,
    explicacao: explicacao,
    uf: uf,
    cep: cep,
    rua: rua,
    pontoRef: pontoRef
   })
  
  //nessa caso, a pagina inicial
  navigate(`/cadastro/confirm/${cnpj}/${nome}`)
} 
  return (
    // <!-- background da pagina -->
    <section className="container-fluid sect-form">
      {/* <!-- imagem de fundo --> */}
      <div className="img-back">
        <img src={ImagemFundo} />
      </div>

      <main className="main-form-geral">
        {/* <!-- icons de navegação --> */}
        <div className="icon">
          {/* <!-- icon 1 --> */}
          <button
            className="icon-btn btn-1"
            style={{ boxShadow: "0 0 8px rgba(0, 0, 0, 0.6)" }}
          >
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="40"
              height="40"
              fill="currentColor"
              className="bi bi-emoji-smile"
              viewBox="0 0 16 16"
            >
              <path d="M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z" />
              <path d="M4.285 9.567a.5.5 0 0 1 .683.183A3.498 3.498 0 0 0 8 11.5a3.498 3.498 0 0 0 3.032-1.75.5.5 0 1 1 .866.5A4.498 4.498 0 0 1 8 12.5a4.498 4.498 0 0 1-3.898-2.25.5.5 0 0 1 .183-.683zM7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm4 0c0 .828-.448 1.5-1 1.5s-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5z" />
            </svg>
          </button>

          <div
            className="linha"
            style={{
              backgroundColor: ativo ? "#97c9cf" : "white",
              boxShadow: "0 0 8px rgba(0, 0, 0, 0.6)",
            }}
          ></div>

          {/* <!-- icon 2 --> */}
          <button
            className="icon-btn btn-2"
            style={{
              backgroundColor: ativo ? "#97c9cf" : "white",
              boxShadow: "0 0 8px rgba(0, 0, 0, 0.6)",
            }}
            id="iconE-2"
          >
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="40"
              height="40"
              fill="currentColor"
              className="bi bi-house"
              viewBox="0 0 16 16"
            >
              <path
                fill-rule="evenodd"
                d="M2 13.5V7h1v6.5a.5.5 0 0 0 .5.5h9a.5.5 0 0 0 .5-.5V7h1v6.5a1.5 1.5 0 0 1-1.5 1.5h-9A1.5 1.5 0 0 1 2 13.5zm11-11V6l-2-2V2.5a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5z"
              />
              <path
                fill-rule="evenodd"
                d="M7.293 1.5a1 1 0 0 1 1.414 0l6.647 6.646a.5.5 0 0 1-.708.708L8 2.207 1.354 8.854a.5.5 0 1 1-.708-.708L7.293 1.5z"
              />
            </svg>
          </button>
        </div>

        {/* <!-- titulo --> */}
        <h3>Cadastrando Instituição/Empresa</h3>

        {/* <!-- começo do formulario pessoa --> */}
        <form className="form-empresa" id="form-empresa" onSubmit={(e) => onSubmit(e)}>
          {/* <!-- PARTE 1 --> */}
          <div 
          className={ativo ? "disp-none" : "nada"} 
          id="formE1">
            {/* <!-- input de texto Nome --> */}
            <div className="div-input">
              <label for="nome">Nome do Representante</label>
              <input
                type="text"
                name="nome"
                value={nome}
                placeholder="Nome completo"
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>
            {/* <!-- input de texto Cargo --> */}
            <div className="div-input">
              <label for="cargo">Cargo do Representante</label>
              <input
                type="text"
                name="cargo"
                value={cargo}
                placeholder="Digite..."
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>
            {/* <!-- input de texto nomeEmp --> */}
            <div className="div-input">
              <label for="nomeEmp">Nome da Empresa/Escola</label>
              <input
                type="text"
                name="instituicao"
                value={instituicao}
                placeholder="Digite..."
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>
            {/* <!-- input de texto Email --> */}
            <div className="div-input">
              <label for="email">Email:</label>
              <input
                type="email"
                name="email"
                value={email}
                placeholder="Digite..."
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>
            {/* <!-- input de texto Telefone  --> */}
            <div className="div-input">
              <label for="telefone">Telefone:</label>
              <input
                type="tel"
                name="telefone"
                value={telefone}
                placeholder="(xx) xxxxx-xxxx"
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>
            {/* <!-- input de texto CPF --> */}
            <div className="div-input">
              <label for="cpf">CNPJ:</label>
              <input
                type="text"
                name="cnpj"
                value={cnpj}
                placeholder="Apenas número"
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>
          </div>
          {/* <!-- PARTE 2 --> */}
          <div 
          className={!ativo ? "disp-none" : "nada"} 
          id="formE2">
            <div className="div-input">
              <label for="nome">CEP e UF</label>
              <div style={{ display: "flex" }}>
                <input
                  type="text"
                  name="cep"
                  value={cep}
                  placeholder="CEP"
                  onChange={(e)=> onInputChange(e)}
                  required
                  style={{ width: "80%" }}
                />
                <input
                  type="text"
                  name="uf"
                  value={uf}
                  placeholder="UF"
                  required
                  onChange={(e)=> onInputChange(e)}
                  style={{
                    width: "10%",
                    borderLeft: "2px solid rgba(0,0,0,0.5)",
                  }}
                />
              </div>
              <div className="underline"></div>
            </div>

            <div className="div-input">
              <label for="email">Endereço</label>
              <input
                type="text"
                name="rua"
                value={rua}
                placeholder="Endereço"
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>

            <div className="div-input">
              <label for="telefone">ponto de Referência</label>
              <input
                type="text"
                name="pontoRef"
                value={pontoRef}
                placeholder="Digite..."
                onChange={(e)=> onInputChange(e)}
                required
              />
              <div className="underline"></div>
            </div>

            <div className="escolha" id="escolhaEmpresa">
              <h5>Nós:</h5>
              <div className="div-input">
                <select 
                name="escolha" 
                onChange={(e)=>choice(e)}
                required
                value={escolha}>
                  <option selected>--</option>
                  <option value="doador">Sou doador</option>
                  <option value="beneficio">Preciso de equipamento</option>
                </select>
                <div className="underline"></div>
              </div>
            </div>

            <div
              style={{textAlign: "center"}}
              className={!ativo ? "btn-continue disp-none" : "btn-continue"}
              onClick={showOptions}
            >
              continue
            </div>
          </div>
           {/* <!-- PARTE 3 --> */}
          <div
            className={escolha == "doador" && ativoII && ativo ? "nada":"disp-none" }
            id="formE3"
          >
            <div className="div-input">
              <label for="escolha">Qual o dispositivo para doação?</label>
              <select 
              name="equipamento" 
              value={equipamento}
              onChange={(e)=> onInputChange(e)}
              required>
                <option value="padrão">--</option>
                <option value="mobile">Celular</option>
                <option value="desktop">Computador</option>
                <option value="laptop">Notebook</option>
              </select>
              <div className="underline"></div>
            </div>

            <div className="div-input">
              <label for="especifiicação">Fale sobre o aparelho:</label>
              <textarea
                name="explicacao"
                value={explicacao}
                cols="30"
                rows="10"
                placeholder="ano, houve problemas, estado atual,etc..."
                onChange={(e)=> onInputChange(e)}
                required
              ></textarea>

              <div className="underline"></div>
            </div>
            <input
              className="confirm"
              id="confirm"
              type="submit"
              value="Enviar"
            />
          </div>
          {/* <!-- PARTE 4 --> */}
          <div
            className={escolha == "beneficio" && ativoII && ativo? "nada" : "disp-none"}
            id="formE4"
          >
            <div class="div-input">
              <label for="especifiicação">Explique sua situação para nós:</label>
              <textarea name="explicacao" value={explicacao} cols="30" rows="10" placeholder="Digite..." onChange={(e)=> onInputChange(e)} required></textarea>

              <div class="underline"></div>
            </div>
              <input class="confirm" id="confirm" type="submit" value="Enviar"></input>
          </div>
        </form>

        {/* <!-- BOTÕES--> */}
        <div className="next-prev">
          {/* <!-- BOTAO PREV --> */}
          <button
            className={!ativo ? "btn-prev disp-none" : "btn-prev"}
            id="btn-prevE"
            onClick={ChangeVisibility}
          >
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="16"
              height="16"
              fill="currentColor"
              className="bi bi-arrow-left"
              viewBox="0 0 16 16"
            >
              <path
                fill-rule="evenodd"
                d="M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z"
              />
            </svg>
          </button>
          {/* <!-- BOTAO NEXT --> */}
          <button
            className={ativo ? "btn-next disp-none" : "btn-next"}
            id="btn-nextE"
            onClick={ChangeVisibility}
          >
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="16"
              height="16"
              fill="currentColor"
              className="bi bi-arrow-right"
              viewBox="0 0 16 16"
            >
              <path
                fill-rule="evenodd"
                d="M1 8a.5.5 0 0 1 .5-.5h11.793l-3.147-3.146a.5.5 0 0 1 .708-.708l4 4a.5.5 0 0 1 0 .708l-4 4a.5.5 0 0 1-.708-.708L13.293 8.5H1.5A.5.5 0 0 1 1 8z"
              />
            </svg>
          </button>
        </div>
      </main>
    </section>
  );
}
