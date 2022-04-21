package com.iesmz.proyectofinal.dmr.domain;

import com.fasterxml.jackson.annotation.JsonIdentityReference;
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
    @Column(name ="idHorario")
    private long idHorario;

    @Schema(description = "Curso del horario", example = "2DAM", required = true)
    @NotBlank
    @Column(name ="curso")
    private String curso;

    @Schema(description = "Dia de la semana del horario", example = "1", required = true)
    @NotBlank
    @Column(name ="diaSemana")
    private int diaSemana; //el dia de la semana será del 1 al 5

    @Schema(description = "Hora de inicio del trabajador en el horario", example = "08:00h", required = true)
    @NotBlank
    @Column(name ="horaInicio")
    private String horaInicio;

    @Schema(description = "Hora final del trabajador en el horario", example = "14:00h", required = true)
    @NotBlank
    @Column(name ="horaFin")
    private String horaFin;

    @ManyToOne
    @JoinColumn(name="idUser")
    @JsonIgnoreProperties("horarios")
    private User user;

    @ManyToOne
    @JoinColumn(name="idAula")
    @JsonIgnoreProperties("horarios")
    private Aula aula;

}
