package com.iesmz.proyectofinal.dmr.domain;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.util.List;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity(name = "departamento")
public class Departamento {

    @Schema(description = "Id del departamento", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long idDepartamento;

    @Schema(description = "Nombre del departamento", example ="Informatica", required = true)
    @NotBlank
    @Column
    private String nombre;

    @OneToMany(mappedBy = "departamento", targetEntity = User.class, cascade = CascadeType.ALL, fetch = FetchType.EAGER)
    private List<User> users;

}
