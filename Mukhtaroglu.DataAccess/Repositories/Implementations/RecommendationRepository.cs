using Mukhtaroglu.DataAccess.Repositories.Implementations.Generic;

namespace Mukhtaroglu.DataAccess.Repositories.Implementations;
internal class RecommendationRepository(AppDbContext context) : Repository<Recommendation>(context), IRecommendationRepository { }
