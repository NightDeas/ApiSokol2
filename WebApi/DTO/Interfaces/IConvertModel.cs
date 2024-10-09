namespace WebApi.DTO.Interfaces
{
    public interface IConvertModel<DTOModel, DALModel>
    {
        DTOModel ConvertDALToDTOModel(DALModel DALModel);
        DALModel ConvertBLLToDALModel(DTOModel DTOModel);
    }
}
