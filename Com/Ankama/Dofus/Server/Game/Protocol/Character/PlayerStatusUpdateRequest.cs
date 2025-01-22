using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character
{
	// Token: 0x020008E3 RID: 2275
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerStatusUpdateRequest : IMessage<PlayerStatusUpdateRequest>, IMessage, IEquatable<PlayerStatusUpdateRequest>, IDeepCloneable<PlayerStatusUpdateRequest>, IBufferMessage
	{
		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x06006E8A RID: 28298 RVA: 0x002378F8 File Offset: 0x00235AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerStatusUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06006E8B RID: 28299 RVA: 0x00237908 File Offset: 0x00235B08
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

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06006E8C RID: 28300 RVA: 0x00237918 File Offset: 0x00235B18
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

		// Token: 0x06006E8D RID: 28301 RVA: 0x00237928 File Offset: 0x00235B28
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdateRequest()
		{
		}

		// Token: 0x06006E8E RID: 28302 RVA: 0x00237938 File Offset: 0x00235B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdateRequest(PlayerStatusUpdateRequest other)
		{
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x00237948 File Offset: 0x00235B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PlayerStatusUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06006E90 RID: 28304 RVA: 0x00237958 File Offset: 0x00235B58
		// (set) Token: 0x06006E91 RID: 28305 RVA: 0x00237968 File Offset: 0x00235B68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public CharacterStatus Status
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

		// Token: 0x06006E92 RID: 28306 RVA: 0x00237978 File Offset: 0x00235B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x00237988 File Offset: 0x00235B88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PlayerStatusUpdateRequest other)
		{
			return true;
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x00237998 File Offset: 0x00235B98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x002379A8 File Offset: 0x00235BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x002379B8 File Offset: 0x00235BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x002379C8 File Offset: 0x00235BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x002379D8 File Offset: 0x00235BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x002379E8 File Offset: 0x00235BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PlayerStatusUpdateRequest other)
		{
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x002379F8 File Offset: 0x00235BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x00237A08 File Offset: 0x00235C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x00237A18 File Offset: 0x00235C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PlayerStatusUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
						num2 = 0;
						if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_21f5734de83f479ea303da2e5b23aa43 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
						num2 = 4;
						continue;
					case 3:
						return;
					case 4:
						goto IL_88;
					}
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b != 0)
					{
						num2 = 2;
					}
				}
				IL_88:
				PlayerStatusUpdateRequest._parser = new MessageParser<PlayerStatusUpdateRequest>(() => null);
				num = 3;
			}
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x00237AE8 File Offset: 0x00235CE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool Gmp3OHJBR1bWO1k8JcxO()
		{
			return true;
		}

		// Token: 0x06006E9E RID: 28318 RVA: 0x00237AF0 File Offset: 0x00235CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PlayerStatusUpdateRequest WCxyDIJBONY5Gy6XaAW6()
		{
			return null;
		}

		// Token: 0x040026BE RID: 9918
		private static readonly MessageParser<PlayerStatusUpdateRequest> _parser;

		// Token: 0x040026BF RID: 9919
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026C0 RID: 9920
		public const int StatusFieldNumber = 1;

		// Token: 0x040026C1 RID: 9921
		private CharacterStatus status_;

		// Token: 0x040026C2 RID: 9922
		internal static PlayerStatusUpdateRequest G0x07CJB3Eu35mZdRFCi;
	}
}
