using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management
{
	// Token: 0x02000911 RID: 2321
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterCreationRequest : IMessage<CharacterCreationRequest>, IMessage, IEquatable<CharacterCreationRequest>, IDeepCloneable<CharacterCreationRequest>, IBufferMessage
	{
		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06007096 RID: 28822 RVA: 0x0023B75C File Offset: 0x0023995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CharacterCreationRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06007097 RID: 28823 RVA: 0x0023B76C File Offset: 0x0023996C
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

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06007098 RID: 28824 RVA: 0x0023B77C File Offset: 0x0023997C
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

		// Token: 0x06007099 RID: 28825 RVA: 0x0023B78C File Offset: 0x0023998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCreationRequest()
		{
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x0023B79C File Offset: 0x0023999C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCreationRequest(CharacterCreationRequest other)
		{
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x0023B7AC File Offset: 0x002399AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterCreationRequest Clone()
		{
			return null;
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600709C RID: 28828 RVA: 0x0023B7BC File Offset: 0x002399BC
		// (set) Token: 0x0600709D RID: 28829 RVA: 0x0023B7CC File Offset: 0x002399CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CharacterRemodelingInformation ModelingInformation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x0023B7DC File Offset: 0x002399DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x0023B7EC File Offset: 0x002399EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterCreationRequest other)
		{
			return true;
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x0023B7FC File Offset: 0x002399FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060070A1 RID: 28833 RVA: 0x0023B80C File Offset: 0x00239A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x0023B81C File Offset: 0x00239A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x0023B82C File Offset: 0x00239A2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x0023B83C File Offset: 0x00239A3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x0023B84C File Offset: 0x00239A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterCreationRequest other)
		{
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x0023B85C File Offset: 0x00239A5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x0023B86C File Offset: 0x00239A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060070A8 RID: 28840 RVA: 0x0023B87C File Offset: 0x00239A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterCreationRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_489c2019c8d9417e8d3b3ace7245e128 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f3bf7efad9a14971bf5a9f33df5ddb1e != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					CharacterCreationRequest._parser = new MessageParser<CharacterCreationRequest>(() => null);
					num2 = 4;
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_1837bd6484274412a963767d86a67356 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060070A9 RID: 28841 RVA: 0x0023B960 File Offset: 0x00239B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool n34B9UJeO5gXeehoGRZ6()
		{
			return true;
		}

		// Token: 0x060070AA RID: 28842 RVA: 0x0023B968 File Offset: 0x00239B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterCreationRequest HQwwtlJeJBFJU3ckvm6u()
		{
			return null;
		}

		// Token: 0x04002779 RID: 10105
		private static readonly MessageParser<CharacterCreationRequest> _parser;

		// Token: 0x0400277A RID: 10106
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400277B RID: 10107
		public const int ModelingInformationFieldNumber = 1;

		// Token: 0x0400277C RID: 10108
		private CharacterRemodelingInformation modelingInformation_;

		// Token: 0x0400277D RID: 10109
		private static CharacterCreationRequest sSXGPGJeR7niPqmFbeKd;
	}
}
