using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPool <T>: MonoBehaviour where T : class {

	private T m_resGameObj ; 
	private GameObject m_componentParent;

	public delegate void OnCall();
	public delegate void OnCall<T0>(T0 arg0);


	public OnCall OnRecycle = null;
	public OnCall OnNew = null;
	public OnCall OnInitialize = null ;

	private List<T> m_pool = new List<T>() ;
	private List<T> m_usePool = new List<T>();

	public GameObjectPool(T resObj) {
		m_resGameObj = resObj;
	}

	public GameObjectPool(GameObject parent) {
		m_componentParent = parent;
	}

	public int Length() {
		return m_pool.Count;
	}

	public T0 get<T0>() where T0 : class	{
		T0 obj = null ;
		if (m_pool.Count > 0) {
			obj = m_pool[m_pool.Count-1] as T0;
			m_usePool.Add(m_pool[m_pool.Count-1]);
			m_pool.RemoveAt(m_pool.Count-1);
		}
		else {
			if (this.OnNew != null) {
				this.OnNew.Invoke();
			}

			Debug.Log("~~~~   type os " + typeof(Component) + " dafdafada " + typeof(T));

			if (m_resGameObj != null && typeof(GameObject) == m_resGameObj.GetType()) {
				obj = Instantiate(m_resGameObj as GameObject) as T0;
				m_usePool.Add(obj as T);
			}
			else if (m_componentParent != null && typeof(Component).IsAssignableFrom(typeof(T) )  ) {

				obj = m_componentParent.AddComponent(typeof(AudioSource)) as T0;
				m_usePool.Add(obj as T);

				Debug.Log("~~~~  new a obj , current used count is " + m_usePool.Count);
			}
			else {
				//TODO: 其他类型的暂不处理
			}
		}

		if (this.OnInitialize != null) {
			this.OnInitialize.Invoke();
		}

		return obj ; 
	}

	public void Recycle<T0>(T0 obj) where T0: class {
		if (obj == null) {
			return ;
		}

		for (int i = 0 ; i < m_usePool.Count ; ++i) {
			if (obj == m_usePool[i]) {
				m_usePool.Remove(obj as T);

				Debug.Log("~~~~ remove usepool   " + m_usePool.Count );
			}
		}

		m_pool.Add(obj as T);

		if (this.OnRecycle != null) {
			this.OnRecycle.Invoke();
		}

		Debug.Log("~~~~  current pool is " + m_pool.Count );
	}

	public List<T> GetAllUseObj() {
		return m_usePool;
	}

	public List<T> GetAllUnUsedObj() {
		return m_pool;
	}
}
