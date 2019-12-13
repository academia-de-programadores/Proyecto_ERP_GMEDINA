USE [ERP_GMEDINA]
GO
/****** Object:  StoredProcedure [rrhh].[UDP_RRHH_tbAreas_Delete]    Script Date: 13/12/2019 9:15:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [rrhh].[UDP_RRHH_tbAreas_Delete]
  (
  @area_Id int,
  @area_Razoninactivo nvarchar(100),
  @area_Usuariomodifica int,
  @area_Fechamodifica datetime
  )
  AS
   SET NOCOUNT ON;
  BEGIN
    BEGIN TRY
      BEGIN TRAN
      DECLARE @Id INT
      SET @Id = @area_Id
	  UPDATE [rrhh].[tbDepartamentos]
      SET
      [depto_Estado] = 0,
      depto_Razoninactivo = 'El area correspondiente ha sido deshabilitada',
      depto_Usuariomodifica = @area_Usuariomodifica,
      depto_Fechamodifica = @area_Fechamodifica
      WHERE area_Id = @area_Id

      UPDATE [RRHH].tbAreas
      SET
      area_Estado = 0,
      area_Razoninactivo = @area_Razoninactivo,
      area_Usuariomodifica = @area_Usuariomodifica,
      area_Fechamodifica = @area_Fechamodifica
      WHERE area_Id = @area_Id
      AND area_Estado = 1
      SELECT
        CAST(@Id AS VARCHAR) AS MensajeError
      COMMIT TRAN
    END TRY
    BEGIN CATCH
      ROLLBACK TRAN
      SELECT
        '-1 ' + ERROR_MESSAGE() AS MensajeError
    END CATCH
  END
