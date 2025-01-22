using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000B37 RID: 2871
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ShortcutCosmeticObject : IMessage<ShortcutCosmeticObject>, IMessage, IEquatable<ShortcutCosmeticObject>, IDeepCloneable<ShortcutCosmeticObject>, IBufferMessage
	{
		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x06008956 RID: 35158 RVA: 0x00267018 File Offset: 0x00265218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShortcutCosmeticObject> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x06008957 RID: 35159 RVA: 0x00267028 File Offset: 0x00265228
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

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x06008958 RID: 35160 RVA: 0x00267038 File Offset: 0x00265238
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

		// Token: 0x06008959 RID: 35161 RVA: 0x00267048 File Offset: 0x00265248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutCosmeticObject()
		{
		}

		// Token: 0x0600895A RID: 35162 RVA: 0x00267058 File Offset: 0x00265258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutCosmeticObject(ShortcutCosmeticObject other)
		{
		}

		// Token: 0x0600895B RID: 35163 RVA: 0x00267068 File Offset: 0x00265268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ShortcutCosmeticObject Clone()
		{
			return null;
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600895C RID: 35164 RVA: 0x00267078 File Offset: 0x00265278
		// (set) Token: 0x0600895D RID: 35165 RVA: 0x00267088 File Offset: 0x00265288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ObjectGid
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

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600895E RID: 35166 RVA: 0x00267098 File Offset: 0x00265298
		// (set) Token: 0x0600895F RID: 35167 RVA: 0x002670A8 File Offset: 0x002652A8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool Enable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x06008960 RID: 35168 RVA: 0x002670B8 File Offset: 0x002652B8
		// (set) Token: 0x06008961 RID: 35169 RVA: 0x002670C8 File Offset: 0x002652C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
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

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x06008962 RID: 35170 RVA: 0x002670D8 File Offset: 0x002652D8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public bool HasSkinId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
		}

		// Token: 0x06008963 RID: 35171 RVA: 0x002670E8 File Offset: 0x002652E8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearSkinId()
		{
		}

		// Token: 0x06008964 RID: 35172 RVA: 0x002670F8 File Offset: 0x002652F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06008965 RID: 35173 RVA: 0x00267108 File Offset: 0x00265308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(ShortcutCosmeticObject other)
		{
			return true;
		}

		// Token: 0x06008966 RID: 35174 RVA: 0x00267118 File Offset: 0x00265318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06008967 RID: 35175 RVA: 0x00267128 File Offset: 0x00265328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06008968 RID: 35176 RVA: 0x00267138 File Offset: 0x00265338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06008969 RID: 35177 RVA: 0x00267148 File Offset: 0x00265348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600896A RID: 35178 RVA: 0x00267158 File Offset: 0x00265358
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600896B RID: 35179 RVA: 0x00267168 File Offset: 0x00265368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(ShortcutCosmeticObject other)
		{
		}

		// Token: 0x0600896C RID: 35180 RVA: 0x00267178 File Offset: 0x00265378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600896D RID: 35181 RVA: 0x00267188 File Offset: 0x00265388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600896E RID: 35182 RVA: 0x00267198 File Offset: 0x00265398
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ShortcutCosmeticObject()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						goto IL_B4;
					case 2:
						return;
					case 3:
						AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_c1eba4e0b34b449ab7fc8da6d2bce1f2 != 0)
						{
							num2 = 0;
						}
						break;
					case 4:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 3;
						break;
					case 5:
						goto IL_63;
					}
				}
				IL_63:
				ShortcutCosmeticObject.SkinIdDefaultValue = 0;
				num = 2;
				continue;
				IL_B4:
				ShortcutCosmeticObject._parser = new MessageParser<ShortcutCosmeticObject>(() => null);
				num = 5;
			}
		}

		// Token: 0x0600896F RID: 35183 RVA: 0x00267280 File Offset: 0x00265480
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool KZ4PFaJdlTooFsJDv4db()
		{
			return true;
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x00267288 File Offset: 0x00265488
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static ShortcutCosmeticObject EZLhD4Jdc7CCAgBnYZN6()
		{
			return null;
		}

		// Token: 0x04003297 RID: 12951
		private static readonly MessageParser<ShortcutCosmeticObject> _parser;

		// Token: 0x04003298 RID: 12952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003299 RID: 12953
		private int _hasBits0;

		// Token: 0x0400329A RID: 12954
		public const int ObjectGidFieldNumber = 1;

		// Token: 0x0400329B RID: 12955
		private int objectGid_;

		// Token: 0x0400329C RID: 12956
		public const int EnableFieldNumber = 3;

		// Token: 0x0400329D RID: 12957
		private bool enable_;

		// Token: 0x0400329E RID: 12958
		public const int SkinIdFieldNumber = 2;

		// Token: 0x0400329F RID: 12959
		private static readonly int SkinIdDefaultValue;

		// Token: 0x040032A0 RID: 12960
		private int skinId_;

		// Token: 0x040032A1 RID: 12961
		internal static ShortcutCosmeticObject mtKrvuJdk0ktxyWrWih5;
	}
}
