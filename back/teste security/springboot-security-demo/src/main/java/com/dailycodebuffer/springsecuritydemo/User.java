 package com.dailycodebuffer.springsecuritydemo;

import javax.persistence.Entity;
import javax.persistence.Id;

@Entity
public class User {

    @Id
    private Long id;
    private String firstname;
    private String lastname;
    private String cpf;
    private String email;
    private String cep;
    private String uf;
    private String escolha;
    private String equipamento;
    private String explicacao;
   
    private String username;
    private String password;
    private String role;
	public Long getId() {
		return id;
	}
	public void setId(Long id) {
		this.id = id;
	}
	public String getFirstname() {
		return firstname;
	}
	public void setFirstname(String firstname) {
		this.firstname = firstname;
	}
	public String getLastname() {
		return lastname;
	}
	public void setLastname(String lastname) {
		this.lastname = lastname;
	}
	public String getCpf() {
		return cpf;
	}
	public void setCpf(String cpf) {
		this.cpf = cpf;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	public String getCep() {
		return cep;
	}
	public void setCep(String cep) {
		this.cep = cep;
	}
	public String getUf() {
		return uf;
	}
	public void setUf(String uf) {
		this.uf = uf;
	}
	public String getEscolha() {
		return escolha;
	}
	public void setEscolha(String escolha) {
		this.escolha = escolha;
	}
	public String getEquipamento() {
		return equipamento;
	}
	public void setEquipamento(String equipamento) {
		this.equipamento = equipamento;
	}
	public String getExplicacao() {
		return explicacao;
	}
	public void setExplicacao(String explicacao) {
		this.explicacao = explicacao;
	}
	public String getUsername() {
		return username;
	}
	public void setUsername(String username) {
		this.username = username;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	public String getRole() {
		return role;
	}
	public void setRole(String role) {
		this.role = role;
	}
	@Override
	public String toString() {
		return "User [id=" + id + ", firstname=" + firstname + ", lastname=" + lastname + ", cpf=" + cpf + ", email="
				+ email + ", cep=" + cep + ", uf=" + uf + ", escolha=" + escolha + ", equipamento=" + equipamento
				+ ", explicacao=" + explicacao + ", username=" + username + ", password=" + password + ", role=" + role
				+ "]";
	}
    
}