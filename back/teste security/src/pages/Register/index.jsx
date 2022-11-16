import { Link } from "react-router-dom";
import { useState } from "react";
import { LayoutComponents } from "../../components/LayoutComponents"

import ptIMG from '../../assets/pt.svg'


export const Register = () => {

  const [firstname, setfirstName] = useState("")
  const [lastname, setlastName] = useState("")
  const [cpf, setCpf] = useState("")
  const [cep, setCep] = useState("")
  const [uf, setUf] = useState("")
  const [escolha, setEscolha] = useState("")
  const [equipamento, setEquipamento] = useState("")
  const [explicacao, setExplicacao] = useState("")
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  return (
    <LayoutComponents >
      <form className="login-form">
        <span className="login-form-title"> Criar Conta </span>

        <span className="login-form-title">
          <img src={ptIMG} alt="Pt" />
        </span>

        <div className="wrap-input">
          <input
            className={firstname !== "" ? "has-val input" : "input"}
            type="email"
            value={firstname}
            onChange={(e) => setfirstName(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Primeiro Nome"></span>
        </div>

        <div className="wrap-input">
          <input
            className={lastname !== "" ? "has-val input" : "input"}
            type="email"
            value={lastname}
            onChange={(e) => setlastName(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Segundo Nome"></span>
        </div>

        
        <div className="wrap-input">
          <input
            className={cpf !== "" ? "has-val input" : "input"}
            type="email"
            value={cpf}
            onChange={(e) => setCpf(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Cpf"></span>
        </div>

        <div className="wrap-input">
          <input
            className={cep !== "" ? "has-val input" : "input"}
            type="email"
            value={cep}
            onChange={(e) => setCep(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Cep"></span>
        </div>

        <div className="wrap-input">
          <input
            className={uf !== "" ? "has-val input" : "input"}
            type="email"
            value={uf}
            onChange={(e) => setUf(e.target.value)}
          />
          <span className="focus-input" data-placeholder="UF"></span>
        </div>

        <div className="wrap-input">
          <input
            className={escolha !== "" ? "has-val input" : "input"}
            type="email"
            value={escolha}
            onChange={(e) => setEscolha(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Escolha"></span>
        </div>

        <div className="wrap-input">
          <input
            className={equipamento !== "" ? "has-val input" : "input"}
            type="email"
            value={equipamento}
            onChange={(e) => setEquipamento(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Equipamento"></span>
        </div>

        <div className="wrap-input">
          <input
            className={explicacao !== "" ? "has-val input" : "input"}
            type="email"
            value={explicacao}
            onChange={(e) => setExplicacao(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Explicação"></span>
        </div>
        



        <div className="wrap-input">
          <input
            className={email !== "" ? "has-val input" : "input"}
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Email"></span>
        </div>

        <div className="wrap-input">
          <input
            className={password !== "" ? "has-val input" : "input"}
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
          />
          <span className="focus-input" data-placeholder="Password"></span>
        </div>

        <div className="container-login-form-btn">
          <button className="login-form-btn">Login</button>
        </div>

        <div className="text-center">
          <span className="txt1">Já possui conta? </span>
          <Link className="txt2" to="/login">
            Acessar com Email e Senha.
          </Link>
        </div>
      </form>
    </LayoutComponents>
  )
}