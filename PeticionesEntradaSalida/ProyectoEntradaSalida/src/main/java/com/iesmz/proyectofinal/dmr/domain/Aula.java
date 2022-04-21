package com.iesmz.proyectofinal.dmr.domain;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.util.ArrayList;
import java.util.List;


@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity(name = "aula")
public class Aula {

    @Schema(description = "Id del aula", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long idAula;

    @Schema(description = "Nombre del aula", example ="Info 1", required = true)
    @NotBlank
    @Column
    private String nombre;

    @OneToMany(mappedBy = "aula", cascade = CascadeType.ALL, orphanRemoval = true)
    private List<Horario> horarios;

}
