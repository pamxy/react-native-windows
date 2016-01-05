﻿using System;
using ReactNative.UIManager;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Text;

namespace ReactNative.Views.Text
{
    public class ReactTextViewManager : BaseViewManager<TextBlock, ReactTextShadowNode>
    {
        private const string ReactClass = "RCTText";

        public override string Name
        {
            get
            {
                return ReactClass;
            }
        }

        protected override TextBlock CreateViewInstanceCore(ThemedReactContext reactContext)
        {
            return new TextBlock();
        }

        protected override ReactTextShadowNode CreateShadowNodeInstanceCore()
        {
            return new ReactTextShadowNode(false);
        }

        protected override void UpdateExtraData(TextBlock root, object extraData)
        {
            var stringData = (string)extraData;
            root.Text = stringData;
        }
    }
}