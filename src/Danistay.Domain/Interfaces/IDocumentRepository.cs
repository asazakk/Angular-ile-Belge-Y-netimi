using Danistay.Domain.Entities;
using Danistay.Domain.Enums;

namespace Danistay.Domain.Interfaces
{
    public interface IDocumentRepository : IRepository<Document>
    {
        Task<IEnumerable<Document>> GetByStatusAsync(DocumentStatus status);
        Task<IEnumerable<Document>> GetByTypeAsync(DocumentType documentType);
        Task<IEnumerable<Document>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Document>> GetRecentDocumentsAsync(int count);
        Task<IEnumerable<Document>> SearchDocumentsAsync(string searchTerm);
        Task<int> GetDocumentCountByStatusAsync(DocumentStatus status);
    }
}
