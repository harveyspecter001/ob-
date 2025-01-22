using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C65 RID: 3173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterFaces : IMessage<CharacterFaces>, IMessage, IEquatable<CharacterFaces>, IDeepCloneable<CharacterFaces>, IBufferMessage
	{
		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06009867 RID: 39015 RVA: 0x0027AE48 File Offset: 0x00279048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterFaces> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06009868 RID: 39016 RVA: 0x0027AE58 File Offset: 0x00279058
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

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x0027AE68 File Offset: 0x00279068
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

		// Token: 0x0600986A RID: 39018 RVA: 0x0027AE78 File Offset: 0x00279078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFaces()
		{
		}

		// Token: 0x0600986B RID: 39019 RVA: 0x0027AE88 File Offset: 0x00279088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFaces(CharacterFaces other)
		{
		}

		// Token: 0x0600986C RID: 39020 RVA: 0x0027AE98 File Offset: 0x00279098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFaces Clone()
		{
			return null;
		}

		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x0600986D RID: 39021 RVA: 0x0027AEA8 File Offset: 0x002790A8
		// (set) Token: 0x0600986E RID: 39022 RVA: 0x0027AEB8 File Offset: 0x002790B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Slots
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

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x0600986F RID: 39023 RVA: 0x0027AEC8 File Offset: 0x002790C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Faces
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06009870 RID: 39024 RVA: 0x0027AED8 File Offset: 0x002790D8
		// (set) Token: 0x06009871 RID: 39025 RVA: 0x0027AEE8 File Offset: 0x002790E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxSlots
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

		// Token: 0x06009872 RID: 39026 RVA: 0x0027AEF8 File Offset: 0x002790F8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009873 RID: 39027 RVA: 0x0027AF08 File Offset: 0x00279108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterFaces other)
		{
			return true;
		}

		// Token: 0x06009874 RID: 39028 RVA: 0x0027AF18 File Offset: 0x00279118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009875 RID: 39029 RVA: 0x0027AF28 File Offset: 0x00279128
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009876 RID: 39030 RVA: 0x0027AF38 File Offset: 0x00279138
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009877 RID: 39031 RVA: 0x0027AF48 File Offset: 0x00279148
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009878 RID: 39032 RVA: 0x0027AF58 File Offset: 0x00279158
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009879 RID: 39033 RVA: 0x0027AF68 File Offset: 0x00279168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterFaces other)
		{
		}

		// Token: 0x0600987A RID: 39034 RVA: 0x0027AF78 File Offset: 0x00279178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x0027AF88 File Offset: 0x00279188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x0027AF98 File Offset: 0x00279198
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterFaces()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_63;
					case 2:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 1;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_69c582fa8dc944029ee69c86f64d16b8 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_37695329d72346d991fecccd9916c78d == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						CharacterFaces._repeated_faces_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(18U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
						num2 = 3;
						continue;
					}
					CharacterFaces._parser = new MessageParser<CharacterFaces>(() => null);
					num2 = 5;
				}
				IL_63:
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num = 4;
			}
		}

		// Token: 0x0600987D RID: 39037 RVA: 0x0027B088 File Offset: 0x00279288
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BJoWtbJNydNbvkGWhokG()
		{
			return true;
		}

		// Token: 0x0600987E RID: 39038 RVA: 0x0027B090 File Offset: 0x00279290
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterFaces fPrmyPJN6rH71rG3IVSS()
		{
			return null;
		}

		// Token: 0x0400388C RID: 14476
		private static readonly MessageParser<CharacterFaces> _parser;

		// Token: 0x0400388D RID: 14477
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400388E RID: 14478
		public const int SlotsFieldNumber = 1;

		// Token: 0x0400388F RID: 14479
		private int slots_;

		// Token: 0x04003890 RID: 14480
		public const int FacesFieldNumber = 2;

		// Token: 0x04003891 RID: 14481
		private static readonly FieldCodec<int> _repeated_faces_codec;

		// Token: 0x04003892 RID: 14482
		private readonly RepeatedField<int> faces_;

		// Token: 0x04003893 RID: 14483
		public const int MaxSlotsFieldNumber = 3;

		// Token: 0x04003894 RID: 14484
		private int maxSlots_;

		// Token: 0x04003895 RID: 14485
		internal static CharacterFaces XlRl48JN5UkBF4JifTbh;
	}
}
