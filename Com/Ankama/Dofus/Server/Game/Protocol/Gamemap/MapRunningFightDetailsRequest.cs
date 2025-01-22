using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000584 RID: 1412
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapRunningFightDetailsRequest : IMessage<MapRunningFightDetailsRequest>, IMessage, IEquatable<MapRunningFightDetailsRequest>, IDeepCloneable<MapRunningFightDetailsRequest>, IBufferMessage
	{
		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060043FD RID: 17405 RVA: 0x001F5BE4 File Offset: 0x001F3DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MapRunningFightDetailsRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060043FE RID: 17406 RVA: 0x001F5BF4 File Offset: 0x001F3DF4
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

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060043FF RID: 17407 RVA: 0x001F5C04 File Offset: 0x001F3E04
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

		// Token: 0x06004400 RID: 17408 RVA: 0x001F5C14 File Offset: 0x001F3E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsRequest()
		{
		}

		// Token: 0x06004401 RID: 17409 RVA: 0x001F5C24 File Offset: 0x001F3E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsRequest(MapRunningFightDetailsRequest other)
		{
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x001F5C34 File Offset: 0x001F3E34
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapRunningFightDetailsRequest Clone()
		{
			return null;
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06004403 RID: 17411 RVA: 0x001F5C44 File Offset: 0x001F3E44
		// (set) Token: 0x06004404 RID: 17412 RVA: 0x001F5C54 File Offset: 0x001F3E54
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public int FightId
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

		// Token: 0x06004405 RID: 17413 RVA: 0x001F5C64 File Offset: 0x001F3E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x001F5C74 File Offset: 0x001F3E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapRunningFightDetailsRequest other)
		{
			return true;
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x001F5C84 File Offset: 0x001F3E84
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x001F5C94 File Offset: 0x001F3E94
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x001F5CA4 File Offset: 0x001F3EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x001F5CB4 File Offset: 0x001F3EB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x001F5CC4 File Offset: 0x001F3EC4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x001F5CD4 File Offset: 0x001F3ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapRunningFightDetailsRequest other)
		{
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x001F5CE4 File Offset: 0x001F3EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x001F5CF4 File Offset: 0x001F3EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x001F5D04 File Offset: 0x001F3F04
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapRunningFightDetailsRequest()
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
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a3352f41efa4477a999311944d3fe01f == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_788ea967924b4fae800c9ff0efe6ebc0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					MapRunningFightDetailsRequest._parser = new MessageParser<MapRunningFightDetailsRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_cfc3d3d0de31471dab715ade277efc6c == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x001F5DFC File Offset: 0x001F3FFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool yQw8B6OYsIa79euYZTso()
		{
			return true;
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x001F5E04 File Offset: 0x001F4004
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapRunningFightDetailsRequest FgH9EaOYdpLKJxuZC7cC()
		{
			return null;
		}

		// Token: 0x04001762 RID: 5986
		private static readonly MessageParser<MapRunningFightDetailsRequest> _parser;

		// Token: 0x04001763 RID: 5987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001764 RID: 5988
		public const int FightIdFieldNumber = 1;

		// Token: 0x04001765 RID: 5989
		private int fightId_;

		// Token: 0x04001766 RID: 5990
		internal static MapRunningFightDetailsRequest wmP0mSOYgBDSFdETT8YX;
	}
}
