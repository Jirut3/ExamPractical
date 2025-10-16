using UnityEngine;
using UnityEngine.InputSystem;
using GameDev3Library.InteractionSystem;

    public class Ch5CapsulePlayerControllerWithActorTrigger : Ch5CapsulePlayerControllerWithPreset
    {
        [SerializeField] protected ActorTriggerHandler m_ActorTriggerHandler;

        protected override void Update()
        {
            base.Update();
            Keyboard keyboard = Keyboard.current;
            if (keyboard[m_Preset.InteractionKey].wasPressedThisFrame)
            {
                PerformInteraction();
            }
        }

        protected virtual void PerformInteraction()
        {
            var interactable = m_ActorTriggerHandler.GetInteractable();
            if (interactable != null)
            {
                interactable.Interact(gameObject);
            }
        }
    }
