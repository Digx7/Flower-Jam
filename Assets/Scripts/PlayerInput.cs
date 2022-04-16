using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
  /* Description --
  *  This script will handel the Input inputs using the new input manager package
  *  This should be what every thing else in the scene refrences when getting the Input input
  */

  [SerializeField] private Input Input;                  // This references the input action map
  //[SerializeField] private Inventory inventory;
  //[SerializeField] private UI_Inventory uiInventory;

  [SerializeField] private Vector2 moveDirection;

  [SerializeField] private Vector2Event moveInput;


  // --- Updates -------------------------------------

  public void Awake() {
      Input = new Input();             // This is needed to set up the input action map
      //inventory = new Inventory();
      //uiInventory.SetInventory(inventory);

      //ItemWorld.SpawnItemWorld(new Vector3(10, 2), new Item { itemType = Item.ItemType.ManaPotion, amount = 1 });

      BindInputs();
  }

  // --- Get/Set -------------------------------------

  private void setMoveDirection(Vector2 input){
    moveDirection = input;
    moveInput.Invoke(moveDirection);
  }

  public Vector2 getMoveDirection(){
    return moveDirection;
  }

  // --- Events -------------------------------------



  // --- BindingInputs ----------------------------------

  // This script will bind the inputs on the Input action map to the needed script
  public void BindInputs() {
      Input.Gameplay.Move.performed += ctx => this.setMoveDirection(ctx.ReadValue<Vector2>()); // This permantly binds the given inputs to the script with no need for any update function

  }

  // --- Enable/Disable --------------------------------

  // This will enable the Input Action Map
  private void OnEnable() {
      Input.Enable();
  }

  // This will enable the Input Action Map
  private void OnDisable() {
      Input.Disable();
  }
}
