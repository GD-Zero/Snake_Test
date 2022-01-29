using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Snake : MonoBehaviour
{
	[SerializeField] private List<Transform> _tails;
	[SerializeField] private float _bonesDistance;
	[SerializeField] private GameObject _bonePrefab;
	[Range(0, 30), SerializeField] private float _moveSpeed;

	public UnityEvent OnEat;

	public void FixedUpdate()
	{
		MoveHead(_moveSpeed);
		MoveTail();
	}

	private void MoveHead(float speed)
    {
		transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

	private void MoveTail()
    {
		float sqrDistance = Mathf.Sqrt(_bonesDistance);
		Vector3 previvousPosition = transform.position;

		foreach (var bone in _tails)
        {
			if ((bone.position - previvousPosition).sqrMagnitude > sqrDistance)
            {
				Vector3 currentBonePosition = bone.position;
				bone.position = previvousPosition;
				previvousPosition = currentBonePosition;
            }
			else
            {
				break;
            }
        }
    }

	private void OnTriggerEnter(Collider other)
    {
		if(other.TryGetComponent(out Eat eat))
        {
		OnEat.Invoke();// test
		Destroy(other.gameObject);

		GameObject bone = Instantiate(_bonePrefab);
		_tails.Add(bone.transform);
		
		//if (OnEat != null)
		//	{
		//		OnEat.Invoke();
		//	}	
        }
    }
}