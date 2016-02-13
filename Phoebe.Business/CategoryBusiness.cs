﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phoebe.Model;

namespace Phoebe.Business
{
    /// <summary>
    /// 类别业务类
    /// </summary>
    public class CategoryBusiness
    {
        #region Field
        private PhoebeContext context;
        #endregion //Field

        #region Constructor
        public CategoryBusiness()
        {
            this.context = new PhoebeContext();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有一级分类
        /// </summary>
        /// <returns></returns>
        public List<FirstCategory> GetFirstCategory()
        {
            return this.context.FirstCategories.ToList();
        }

        /// <summary>
        /// 获取所有一级分类
        /// </summary>
        /// <param name="showEmpty">是否显示空分类</param>
        /// <returns></returns>
        public List<FirstCategory> GetFirstCategory(bool showEmpty)
        {
            if (showEmpty)
                return GetFirstCategory();
            else
                return this.context.FirstCategories.Where(r => r.ID != 0).ToList();
        }

        /// <summary>
        /// 获取一级分类
        /// </summary>
        /// <param name="id">一级分类ID</param>
        /// <returns></returns>
        public FirstCategory GetFirstCategory(int id)
        {
            return this.context.FirstCategories.Find(id);
        }

        /// <summary>
        /// 获取所有二级分类
        /// </summary>
        /// <returns></returns>
        public List<SecondCategory> GetSecondCategory()
        {
            return this.context.SecondCategories.ToList();
        }

        /// <summary>
        /// 获取一级分类下二级分类
        /// </summary>
        /// <param name="firstId">一级分类ID</param>
        /// <returns></returns>
        public List<SecondCategory> GetSecondCategoryByFirst(int firstId)
        {
            return this.context.SecondCategories.Where(r => r.FirstCategoryID == firstId || r.ID == 0).ToList();
        }

        /// <summary>
        /// 获取一级分类下二级分类
        /// </summary>
        /// <param name="firstId">一级分类ID</param>
        /// <param name="showEmpty"></param>
        /// <returns></returns>
        public List<SecondCategory> GetSecondCategoryByFirst(int firstId, bool showEmpty)
        {
            if (showEmpty)
                return GetSecondCategoryByFirst(firstId);
            else
                return this.context.SecondCategories.Where(r => r.FirstCategoryID == firstId).ToList();
        }

        /// <summary>
        /// 获取二级分类
        /// </summary>
        /// <param name="id">二级分类ID</param>
        /// <returns></returns>
        public SecondCategory GetSecondCategory(int id)
        {
            return this.context.SecondCategories.Find(id);
        }

        /// <summary>
        /// 获取空二级分类
        /// </summary>
        /// <returns></returns>
        public List<SecondCategory> GetSecondEmpty()
        {
            return this.context.SecondCategories.Where(r => r.ID == 0).ToList();
        }

        /// <summary>
        /// 获取所有三级分类
        /// </summary>
        /// <returns></returns>
        public List<ThirdCategory> GetThirdCategory()
        {
            return this.context.ThirdCategories.ToList();
        }

        /// <summary>
        /// 获取二级分类下三级分离
        /// </summary>
        /// <param name="secondId">二级分类ID</param>
        /// <returns></returns>
        public List<ThirdCategory> GetThirdCategoryBySecond(int secondId)
        {
            return this.context.ThirdCategories.Where(r => r.SecondCategoryID == secondId || r.ID == 0).ToList();
        }

        /// <summary>
        /// 获取二级分类下三级分离
        /// </summary>
        /// <param name="secondId">二级分类ID</param>
        /// <param name="showEmpty"></param>
        /// <returns></returns>
        public List<ThirdCategory> GetThirdCategoryBySecond(int secondId, bool showEmpty)
        {
            if (showEmpty)
                return GetThirdCategoryBySecond(secondId);
            else
                return this.context.ThirdCategories.Where(r => r.SecondCategoryID == secondId).ToList();
        }

        /// <summary>
        /// 获取三级分类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ThirdCategory GetThirdCategory(int id)
        {
            return this.context.ThirdCategories.Find(id);
        }

        /// <summary>
        /// 添加一级分类
        /// </summary>
        /// <param name="data">一级分类数据</param>
        /// <returns></returns>
        public ErrorCode CreateFirstCategory(FirstCategory data)
        {
            try
            {
                data.Status = 0;
                this.context.FirstCategories.Add(data);
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 添加二级分类
        /// </summary>
        /// <param name="data">二级分类数据</param>
        /// <returns></returns>
        public ErrorCode CreateSecondCategory(SecondCategory data)
        {
            try
            {
                data.Status = 0;
                this.context.SecondCategories.Add(data);
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 添加三级分类
        /// </summary>
        /// <param name="data">三级分类数据</param>
        /// <returns></returns>
        public ErrorCode CreateThirdCategory(ThirdCategory data)
        {
            try
            {
                data.Status = 0;
                this.context.ThirdCategories.Add(data);
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 编辑一级分类
        /// </summary>
        /// <param name="data">一级分类数据</param>
        /// <returns></returns>
        public ErrorCode EditFirstCategory(FirstCategory data)
        {
            try
            {
                this.context.Entry(data).State = EntityState.Modified;
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 编辑二级分类
        /// </summary>
        /// <param name="data">二级分类数据</param>
        /// <returns></returns>
        public ErrorCode EditSecondCategory(SecondCategory data)
        {
            try
            {
                this.context.Entry(data).State = EntityState.Modified;
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 编辑三级分类
        /// </summary>
        /// <param name="data">三级分类数据</param>
        /// <returns></returns>
        public ErrorCode EditThirdCategory(ThirdCategory data)
        {
            try
            {
                this.context.Entry(data).State = EntityState.Modified;
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 删除一级分类
        /// </summary>
        /// <param name="id">一级分类ID</param>
        /// <returns></returns>
        public ErrorCode DeleteFirstCategory(int id)
        {
            try
            {
                var data = this.context.FirstCategories.Find(id);
                if (data == null)
                    return ErrorCode.ObjectNotFound;

                if (this.context.SecondCategories.Count(r => r.FirstCategoryID == data.ID) > 0)
                    return ErrorCode.CategoryHasChild;

                if (this.context.Cargoes.Count(r => r.FirstCategoryID == data.ID) > 0)
                    return ErrorCode.CategoryHasCargo;

                this.context.FirstCategories.Remove(data);
                this.context.SaveChanges();

                return ErrorCode.Success;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }

        /// <summary>
        /// 删除二级分类
        /// </summary>
        /// <param name="id">二级分类ID</param>
        /// <returns></returns>
        public ErrorCode DeleteSecondCategory(int id)
        {
            try
            {
                var data = this.context.SecondCategories.Find(id);
                if (data == null)
                    return ErrorCode.ObjectNotFound;

                if (this.context.ThirdCategories.Count(r => r.SecondCategoryID == data.ID) > 0)
                    return ErrorCode.CategoryHasChild;

                if (this.context.Cargoes.Count(r => r.SecondCategoryID == data.ID) > 0)
                    return ErrorCode.CategoryHasCargo;

                this.context.SecondCategories.Remove(data);
                this.context.SaveChanges();

                return ErrorCode.Success;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }

        /// <summary>
        /// 删除三级分类
        /// </summary>
        /// <param name="id">三级分类ID</param>
        /// <returns></returns>
        public ErrorCode DeleteThirdCategory(int id)
        {
            try
            {
                var data = this.context.ThirdCategories.Find(id);
                if (data == null)
                    return ErrorCode.ObjectNotFound;

                if (this.context.Cargoes.Count(r => r.ThirdCategoryID == data.ID) > 0)
                    return ErrorCode.CategoryHasCargo;

                this.context.ThirdCategories.Remove(data);
                this.context.SaveChanges();

                return ErrorCode.Success;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }
        #endregion //Method
    }
}
