using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag
{
	// Token: 0x0200048B RID: 1163
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HavenBagPermissionsUpdateRequest : IMessage<HavenBagPermissionsUpdateRequest>, IMessage, IEquatable<HavenBagPermissionsUpdateRequest>, IDeepCloneable<HavenBagPermissionsUpdateRequest>, IBufferMessage
	{
		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x001DF928 File Offset: 0x001DDB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HavenBagPermissionsUpdateRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x001DF938 File Offset: 0x001DDB38
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

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x001DF948 File Offset: 0x001DDB48
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

		// Token: 0x060037B1 RID: 14257 RVA: 0x001DF958 File Offset: 0x001DDB58
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPermissionsUpdateRequest()
		{
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x001DF968 File Offset: 0x001DDB68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPermissionsUpdateRequest(HavenBagPermissionsUpdateRequest other)
		{
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x001DF978 File Offset: 0x001DDB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HavenBagPermissionsUpdateRequest Clone()
		{
			return null;
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x001DF988 File Offset: 0x001DDB88
		// (set) Token: 0x060037B5 RID: 14261 RVA: 0x001DF998 File Offset: 0x001DDB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Permissions
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

		// Token: 0x060037B6 RID: 14262 RVA: 0x001DF9A8 File Offset: 0x001DDBA8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x001DF9B8 File Offset: 0x001DDBB8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HavenBagPermissionsUpdateRequest other)
		{
			return true;
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x001DF9C8 File Offset: 0x001DDBC8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x001DF9D8 File Offset: 0x001DDBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x001DF9E8 File Offset: 0x001DDBE8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x001DF9F8 File Offset: 0x001DDBF8
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x001DFA08 File Offset: 0x001DDC08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x001DFA18 File Offset: 0x001DDC18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HavenBagPermissionsUpdateRequest other)
		{
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x001DFA28 File Offset: 0x001DDC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x001DFA38 File Offset: 0x001DDC38
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x001DFA48 File Offset: 0x001DDC48
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HavenBagPermissionsUpdateRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					HavenBagPermissionsUpdateRequest._parser = new MessageParser<HavenBagPermissionsUpdateRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_f7bf54b38c0d4b029a0cfc85211b2f9e != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3fc61538d49f45c8bc242e16fb654591 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 3;
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 1;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x001DFB2C File Offset: 0x001DDD2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool QMOJu3Owj17bCOU94GUd()
		{
			return true;
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x001DFB34 File Offset: 0x001DDD34
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HavenBagPermissionsUpdateRequest SJKel1OwKMx5wf14l2pY()
		{
			return null;
		}

		// Token: 0x04001378 RID: 4984
		private static readonly MessageParser<HavenBagPermissionsUpdateRequest> _parser;

		// Token: 0x04001379 RID: 4985
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400137A RID: 4986
		public const int PermissionsFieldNumber = 1;

		// Token: 0x0400137B RID: 4987
		private int permissions_;

		// Token: 0x0400137C RID: 4988
		internal static HavenBagPermissionsUpdateRequest cUDEO8Ow4s1bYkL5PNyV;
	}
}
