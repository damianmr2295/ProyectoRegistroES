package com.iesmz.proyectofinal.dmr.domain;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;
import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity(name = "horario")
public class Horario {

    @Schema(description = "id del horario", example = "1", required = true)
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long idHorario;

    @Schema(description = "Curso del horario", example = "2DAM", required = true)
    @NotBlank
    @Column
    private String curso;

    @Schema(description = "Dia de la semana del horario", example = "1", required = true)
    @NotBlank
    @Column
    private int diaSemana; //el dia de la semana será del 1 al 5

    @Schema(description = "Hora de inicio del trabajador en el horario", example = "08:00h", required = true)
    @NotBlank
    @Column
    private String horaInicio;

    @Schema(description = "Hora final del trabajador en el horario", example = "14:00h", required = true)
    @NotBlank
    @Column
    private String horaFin;

    @ManyToOne
    @JoinColumn(name="dni")
    private User user;

    @ManyToOne
    @JoinColumn(name="idAula")
    private Aula aula;

    @OneToOne(mappedBy = "horario",fetch = FetchType.LAZY)
    private Fichas fichas;
}
