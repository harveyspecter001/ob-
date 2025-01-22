using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000BB1 RID: 2993
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpellModifier : IMessage<SpellModifier>, IMessage, IEquatable<SpellModifier>, IDeepCloneable<SpellModifier>, IBufferMessage
	{
		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06008FF8 RID: 36856 RVA: 0x0026CE3C File Offset: 0x0026B03C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<SpellModifier> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x0026CE4C File Offset: 0x0026B04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06008FFA RID: 36858 RVA: 0x0026CE5C File Offset: 0x0026B05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x0026CE6C File Offset: 0x0026B06C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellModifier()
		{
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x0026CE7C File Offset: 0x0026B07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellModifier(SpellModifier other)
		{
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0026CE8C File Offset: 0x0026B08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpellModifier Clone()
		{
			return null;
		}

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06008FFE RID: 36862 RVA: 0x0026CE9C File Offset: 0x0026B09C
		// (set) Token: 0x06008FFF RID: 36863 RVA: 0x0026CEAC File Offset: 0x0026B0AC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int SpellId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06009000 RID: 36864 RVA: 0x0026CEBC File Offset: 0x0026B0BC
		// (set) Token: 0x06009001 RID: 36865 RVA: 0x0026CED0 File Offset: 0x0026B0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpellModifierActionType ActionType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SpellModifierActionType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06009002 RID: 36866 RVA: 0x0026CEE0 File Offset: 0x0026B0E0
		// (set) Token: 0x06009003 RID: 36867 RVA: 0x0026CEF4 File Offset: 0x0026B0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpellModifierType ModifierType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (SpellModifierType)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06009004 RID: 36868 RVA: 0x0026CF04 File Offset: 0x0026B104
		// (set) Token: 0x06009005 RID: 36869 RVA: 0x0026CF14 File Offset: 0x0026B114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Context
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06009006 RID: 36870 RVA: 0x0026CF24 File Offset: 0x0026B124
		// (set) Token: 0x06009007 RID: 36871 RVA: 0x0026CF34 File Offset: 0x0026B134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Equipment
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06009008 RID: 36872 RVA: 0x0026CF44 File Offset: 0x0026B144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x0026CF54 File Offset: 0x0026B154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(SpellModifier other)
		{
			return true;
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x0026CF64 File Offset: 0x0026B164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0026CF74 File Offset: 0x0026B174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600900C RID: 36876 RVA: 0x0026CF84 File Offset: 0x0026B184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600900D RID: 36877 RVA: 0x0026CF94 File Offset: 0x0026B194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x0026CFA4 File Offset: 0x0026B1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x0026CFB4 File Offset: 0x0026B1B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(SpellModifier other)
		{
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0026CFC4 File Offset: 0x0026B1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0026CFD4 File Offset: 0x0026B1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x0026CFE4 File Offset: 0x0026B1E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		static SpellModifier()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_b13adc788c2b4a3ba01ee25b354c05a3 != 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1ec83f26d4c1483f862b49c9ea359f2a == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					break;
				case 3:
					SpellModifier._parser = new MessageParser<SpellModifier>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_58898f546bce4558b12e99a036fd5e92 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					return;
				}
			}
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x0026D0C8 File Offset: 0x0026B2C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iUUoGtJ23rurhTkkIgTv()
		{
			return true;
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x0026D0D0 File Offset: 0x0026B2D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static SpellModifier wC25yZJ2RDI9pLsI2aEZ()
		{
			return null;
		}

		// Token: 0x040035A2 RID: 13730
		private static readonly MessageParser<SpellModifier> _parser;

		// Token: 0x040035A3 RID: 13731
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035A4 RID: 13732
		public const int SpellIdFieldNumber = 1;

		// Token: 0x040035A5 RID: 13733
		private int spellId_;

		// Token: 0x040035A6 RID: 13734
		public const int ActionTypeFieldNumber = 2;

		// Token: 0x040035A7 RID: 13735
		private SpellModifierActionType actionType_;

		// Token: 0x040035A8 RID: 13736
		public const int ModifierTypeFieldNumber = 3;

		// Token: 0x040035A9 RID: 13737
		private SpellModifierType modifierType_;

		// Token: 0x040035AA RID: 13738
		public const int ContextFieldNumber = 4;

		// Token: 0x040035AB RID: 13739
		private int context_;

		// Token: 0x040035AC RID: 13740
		public const int EquipmentFieldNumber = 5;

		// Token: 0x040035AD RID: 13741
		private int equipment_;

		// Token: 0x040035AE RID: 13742
		internal static SpellModifier CSZWWrJ2e8UZWcKJfj7Q;
	}
}
