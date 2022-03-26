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
@Entity(name = "Aula")
public class Aula {

    @Schema(description = "Id del aula", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;

    @Schema(description = "Nombre del aula", example ="Info 1", required = true)
    @NotBlank
    @Column
    private String nombre;


}
