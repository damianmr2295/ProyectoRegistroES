package com.iesmz.proyectofinal.dmr.domain;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity(name = "Departamento")
public class Departamento {

    @Schema(description = "Id del departamento", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    @Schema(description = "Nombre del departamento", example ="Informatica", required = true)
    @NotBlank
    @Column
    private String nombre;

}
