using UnityEngine;

// *** DVI Avatar Customize ***

namespace DVI
{
    public class CustomizeAvatar : MonoBehaviour
    { 
        [AvatarHub.Avatar()]
        public void LoadAvatar()
            => DvisionHub.avatar.LoadAvatar();

        [AvatarHub.Avatar()]
        public void LoadMyAvatar()
            => DvisionHub.avatar.LoadMyAvatar();

        [AvatarHub.Avatar()]
        public void ShuffleAvatar()
            => DvisionHub.avatar.ShuffleAvatar();

        [AvatarHub.Avatar()]
        public void NextAvatar()
            => DvisionHub.avatar.NextAvatar();

        [AvatarHub.Avatar()]
        public void PrevAvatar()
            => DvisionHub.avatar.PrevAvatar();

        [AvatarHub.Avatar()]
        public void SelectGenderMale()
            => DvisionHub.avatar.SelectGenderMale();

        [AvatarHub.Avatar()]
        public void SelectGenderFemale()
            => DvisionHub.avatar.SelectGenderFemale();

        [AvatarHub.Avatar()]
        public void SelectGenderThey()
            => DvisionHub.avatar.SelectGenderThey();

        [AvatarHub.Avatar()]
        public void SelectSkinTone(AvatarHub.Data_SkinTone data)
            => DvisionHub.avatar.SelectSkinTone(data);

        [AvatarHub.Avatar()]
        public void SelectShape(AvatarHub.Data_Shape data)
            => DvisionHub.avatar.SelectShape(data);

        [AvatarHub.Avatar()]
        public void ChangeCategory(AvatarHub.Data_Category data)
            => DvisionHub.avatar.ChangeCategory(data);

        [AvatarHub.Avatar()]
        public void CustomizePageBack()
            => DvisionHub.avatar.CustomizePageBack();

        [AvatarHub.Avatar()]
        public void OnValueChangedNickname(string data)
            => DvisionHub.avatar.OnValueChangedNickname(data);

        [AvatarHub.Avatar()]
        public void OnEndEditNickname(string data)
           => DvisionHub.avatar.OnEndEditNickname(data);

        [AvatarHub.Avatar()]
        public void OnDragAvatar(Vector2 data)
            => DvisionHub.avatar.OnDragAvatar(data);

        [AvatarHub.Avatar()]
        public void Undo()
            => DvisionHub.avatar.Undo();

        [AvatarHub.Avatar()]
        public void Redo()
            => DvisionHub.avatar.Redo();

        [AvatarHub.Avatar()]
        public void Init()
            => DvisionHub.avatar.Init();

        [AvatarHub.Avatar()]
        public void CustomizeComplete()
            => DvisionHub.avatar.CustomizeComplete();

        [AvatarHub.Avatar()]
        public void SelectLanguage(DvisionHub.Data_Language data)
            => DvisionHub.avatar.SelectLanguage(data);
    }
}