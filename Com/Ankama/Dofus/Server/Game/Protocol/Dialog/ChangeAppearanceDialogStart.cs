using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Dialog
{
	// Token: 0x020007E4 RID: 2020
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChangeAppearanceDialogStart : IMessage<ChangeAppearanceDialogStart>, IMessage, IEquatable<ChangeAppearanceDialogStart>, IDeepCloneable<ChangeAppearanceDialogStart>, IBufferMessage
	{
		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060062BC RID: 25276 RVA: 0x002236E8 File Offset: 0x002218E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<ChangeAppearanceDialogStart> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060062BD RID: 25277 RVA: 0x002236F8 File Offset: 0x002218F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060062BE RID: 25278 RVA: 0x00223708 File Offset: 0x00221908
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x00223718 File Offset: 0x00221918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogStart()
		{
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x00223728 File Offset: 0x00221928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogStart(ChangeAppearanceDialogStart other)
		{
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x00223738 File Offset: 0x00221938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeAppearanceDialogStart Clone()
		{
			return null;
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060062C2 RID: 25282 RVA: 0x00223748 File Offset: 0x00221948
		// (set) Token: 0x060062C3 RID: 25283 RVA: 0x0022375C File Offset: 0x0022195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeAppearanceDialogStart.Types.AppearanceType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (ChangeAppearanceDialogStart.Types.AppearanceType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x0022376C File Offset: 0x0022196C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x0022377C File Offset: 0x0022197C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ChangeAppearanceDialogStart other)
		{
			return true;
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x0022378C File Offset: 0x0022198C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x0022379C File Offset: 0x0022199C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x002237AC File Offset: 0x002219AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x002237BC File Offset: 0x002219BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x002237CC File Offset: 0x002219CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x002237DC File Offset: 0x002219DC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ChangeAppearanceDialogStart other)
		{
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x002237EC File Offset: 0x002219EC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x002237FC File Offset: 0x002219FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x0022380C File Offset: 0x00221A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ChangeAppearanceDialogStart()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 3;
					break;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2d2589a17466462b8f45c545634b0246 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					ChangeAppearanceDialogStart._parser = new MessageParser<ChangeAppearanceDialogStart>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_eb651aa148a24bd79aa26938672cd28a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x002238F0 File Offset: 0x00221AF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool HCDhuAOFiNYigQDuWy7y()
		{
			return true;
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x002238F8 File Offset: 0x00221AF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ChangeAppearanceDialogStart EEWvcMOFPh85Qg1iRIcY()
		{
			return null;
		}

		// Token: 0x040022B1 RID: 8881
		private static readonly MessageParser<ChangeAppearanceDialogStart> _parser;

		// Token: 0x040022B2 RID: 8882
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022B3 RID: 8883
		public const int TypeFieldNumber = 1;

		// Token: 0x040022B4 RID: 8884
		private ChangeAppearanceDialogStart.Types.AppearanceType type_;

		// Token: 0x040022B5 RID: 8885
		internal static ChangeAppearanceDialogStart xbaVRZOFbaUhFtb8oHRG;

		// Token: 0x020007E5 RID: 2021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static class Types
		{
			// Token: 0x060062D1 RID: 25297 RVA: 0x002D3DA0 File Offset: 0x002D1FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			static Types()
			{
				uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
				xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
			}

			// Token: 0x020007E6 RID: 2022
			public enum AppearanceType
			{
				// Token: 0x040022B7 RID: 8887
				[OriginalName("BODY")]
				Body,
				// Token: 0x040022B8 RID: 8888
				[OriginalName("FACE")]
				Face,
				// Token: 0x040022B9 RID: 8889
				[OriginalName("COLORS")]
				Colors,
				// Token: 0x040022BA RID: 8890
				[OriginalName("GENDER")]
				Gender,
				// Token: 0x040022BB RID: 8891
				[OriginalName("BREED")]
				Breed,
				// Token: 0x040022BC RID: 8892
				[OriginalName("NAME")]
				Name
			}
		}
	}
}
