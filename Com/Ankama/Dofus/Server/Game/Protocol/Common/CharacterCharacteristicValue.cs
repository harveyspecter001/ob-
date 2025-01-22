using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common
{
	// Token: 0x02000A57 RID: 2647
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCharacteristicValue : IMessage<CharacterCharacteristicValue>, IMessage, IEquatable<CharacterCharacteristicValue>, IDeepCloneable<CharacterCharacteristicValue>, IBufferMessage
	{
		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06007E2C RID: 32300 RVA: 0x0025DA2C File Offset: 0x0025BC2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterCharacteristicValue> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06007E2D RID: 32301 RVA: 0x0025DA3C File Offset: 0x0025BC3C
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

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06007E2E RID: 32302 RVA: 0x0025DA4C File Offset: 0x0025BC4C
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

		// Token: 0x06007E2F RID: 32303 RVA: 0x0025DA5C File Offset: 0x0025BC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicValue()
		{
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x0025DA6C File Offset: 0x0025BC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicValue(CharacterCharacteristicValue other)
		{
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x0025DA7C File Offset: 0x0025BC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCharacteristicValue Clone()
		{
			return null;
		}

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06007E32 RID: 32306 RVA: 0x0025DA8C File Offset: 0x0025BC8C
		// (set) Token: 0x06007E33 RID: 32307 RVA: 0x0025DA9C File Offset: 0x0025BC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public long Total
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0L;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x0025DAAC File Offset: 0x0025BCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x0025DABC File Offset: 0x0025BCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCharacteristicValue other)
		{
			return true;
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x0025DACC File Offset: 0x0025BCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0025DADC File Offset: 0x0025BCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0025DAEC File Offset: 0x0025BCEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x0025DAFC File Offset: 0x0025BCFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x0025DB0C File Offset: 0x0025BD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x0025DB1C File Offset: 0x0025BD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCharacteristicValue other)
		{
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x0025DB2C File Offset: 0x0025BD2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x0025DB3C File Offset: 0x0025BD3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x0025DB4C File Offset: 0x0025BD4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCharacteristicValue()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4ae97af170224421bba26a95f19e5eca != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				CharacterCharacteristicValue._parser = new MessageParser<CharacterCharacteristicValue>(() => null);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_71dca1ff0fd74eeaaa43654efcc0aad0 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x0025DC18 File Offset: 0x0025BE18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool IaupJ1JGhKGpC7wktPmf()
		{
			return true;
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x0025DC20 File Offset: 0x0025BE20
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCharacteristicValue X31w82JGrKGqi39dcZLu()
		{
			return null;
		}

		// Token: 0x04002D95 RID: 11669
		private static readonly MessageParser<CharacterCharacteristicValue> _parser;

		// Token: 0x04002D96 RID: 11670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D97 RID: 11671
		public const int TotalFieldNumber = 1;

		// Token: 0x04002D98 RID: 11672
		private long total_;

		// Token: 0x04002D99 RID: 11673
		private static CharacterCharacteristicValue M9bpN3JGWTqsKqr87f7B;
	}
}
