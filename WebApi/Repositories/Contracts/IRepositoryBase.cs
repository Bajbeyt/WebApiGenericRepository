using System;
using System.Linq.Expressions;

namespace Repositories.Contracts
{
	public interface IRepositoryBase<T>
	{
		void GenericCreate(T entity);//Değiliklik yapılan veriyi izlemesi için kullanıyoruz
		IQueryable<T> GenericRead(bool trackChanges); //Sorgulanabilir bir ifade için IQueryable kullandık
		void GenericUpdate(T entity);
		void GenericDelete(T entity);

		IQueryable<T> GenericReadExpression( bool trackChanges, Expression <Func<T,bool>> expression);
		//Expression
		//Func birinci gelen parametreleri arasında filtreleme yapıyor

	}
}

