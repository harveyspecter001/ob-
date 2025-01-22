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
	// Token: 0x02000C75 RID: 3189
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterFillSlotColorsRequest : IMessage<CharacterFillSlotColorsRequest>, IMessage, IEquatable<CharacterFillSlotColorsRequest>, IDeepCloneable<CharacterFillSlotColorsRequest>, IBufferMessage
	{
		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06009927 RID: 39207 RVA: 0x0027B980 File Offset: 0x00279B80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterFillSlotColorsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06009928 RID: 39208 RVA: 0x0027B990 File Offset: 0x00279B90
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

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06009929 RID: 39209 RVA: 0x0027B9A0 File Offset: 0x00279BA0
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

		// Token: 0x0600992A RID: 39210 RVA: 0x0027B9B0 File Offset: 0x00279BB0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotColorsRequest()
		{
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x0027B9C0 File Offset: 0x00279BC0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotColorsRequest(CharacterFillSlotColorsRequest other)
		{
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x0027B9D0 File Offset: 0x00279BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterFillSlotColorsRequest Clone()
		{
			return null;
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x0600992D RID: 39213 RVA: 0x0027B9E0 File Offset: 0x00279BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Colors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x0027B9F0 File Offset: 0x00279BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600992F RID: 39215 RVA: 0x0027BA00 File Offset: 0x00279C00
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterFillSlotColorsRequest other)
		{
			return true;
		}

		// Token: 0x06009930 RID: 39216 RVA: 0x0027BA10 File Offset: 0x00279C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x0027BA20 File Offset: 0x00279C20
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009932 RID: 39218 RVA: 0x0027BA30 File Offset: 0x00279C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009933 RID: 39219 RVA: 0x0027BA40 File Offset: 0x00279C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009934 RID: 39220 RVA: 0x0027BA50 File Offset: 0x00279C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009935 RID: 39221 RVA: 0x0027BA60 File Offset: 0x00279C60
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterFillSlotColorsRequest other)
		{
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x0027BA70 File Offset: 0x00279C70
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x0027BA80 File Offset: 0x00279C80
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x0027BA90 File Offset: 0x00279C90
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterFillSlotColorsRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 5;
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7dffff2eb1b849cc96c1b1e17cd952bf != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					CharacterFillSlotColorsRequest._repeated_colors_codec = M86nYSs6HwlxZ95MMuN.XVInXhlssT(10U, M86nYSs6HwlxZ95MMuN.odfsLRrd4X);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					CharacterFillSlotColorsRequest._parser = new MessageParser<CharacterFillSlotColorsRequest>(() => null);
					num2 = 3;
					continue;
				case 5:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				}
				break;
			}
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x0027BB7C File Offset: 0x00279D7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Dg5fkdJNpOOs6Bvmfg6D()
		{
			return true;
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x0027BB84 File Offset: 0x00279D84
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterFillSlotColorsRequest pcZ03YJNHr4RP6QgfCa5()
		{
			return null;
		}

		// Token: 0x040038CE RID: 14542
		private static readonly MessageParser<CharacterFillSlotColorsRequest> _parser;

		// Token: 0x040038CF RID: 14543
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038D0 RID: 14544
		public const int ColorsFieldNumber = 1;

		// Token: 0x040038D1 RID: 14545
		private static readonly FieldCodec<int> _repeated_colors_codec;

		// Token: 0x040038D2 RID: 14546
		private readonly RepeatedField<int> colors_;

		// Token: 0x040038D3 RID: 14547
		private static CharacterFillSlotColorsRequest AbfK7lJNTbW8H2u56TNa;
	}
}
